﻿using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System;
using UnityEngine.UI;
using System.IO;
using System.Collections.Generic;

public class HeadSpriteUtils : UnitySingleton<HeadSpriteUtils>
{
    public delegate void loadCompleteCallback(Image desImage);
    private Texture2D _uploadTexture = null;
    private Sprite _uploadSprite = null;
    private bool _loading = false;
    private Shader _outputShader;
    private Dictionary<int, Sprite> _headSpriteDict = new Dictionary<int, Sprite>();
    private Dictionary<int, Sprite> _backSpriteDict = new Dictionary<int, Sprite>();
    private Sprite _defaultSprite;
    private string _customIdent = "Textures/";
    private string _systemHeadIdent = "HeadSprites/";
    private string _systemBackIdent = "BackSprites";
    private string _headPath;
    private string _backPath;

    public override void SingletonInit()
    {
        base.SingletonInit();
        _headPath = Application.persistentDataPath + "/UserHead/";
        _backPath = Application.persistentDataPath + "/UserBack/";
        _outputShader = Shader.Find("UI/Default");
        _defaultSprite = Resources.Load<Sprite>(GameDefine.DefaultHeadSprite);
    }

    #region 头像
    public void SetHead(Image desImage, int userId)
    {
        if (_headSpriteDict.ContainsKey(userId))
        {
            desImage.sprite = _headSpriteDict[userId];
            return;
        }
        AccountSaveData data = XMLSaver.saveData.GetAccountData(userId);
        if (string.IsNullOrEmpty(data.headSprite))
        {
            desImage.sprite = _defaultSprite;
            _headSpriteDict.Add(userId, _defaultSprite);
            return;
        }
        if (data.headSprite.IndexOf(_systemHeadIdent) == 0)
        {
            Sprite sprite = Resources.Load<Sprite>(data.headSprite);
            if (sprite == null)
                sprite = _defaultSprite;
            desImage.sprite = sprite;
            _headSpriteDict.Add(userId, sprite);
            return;
        }
        desImage.sprite = _defaultSprite;
        StartCoroutine(GetHeadTexture(userId, desImage, _headPath + data.headSprite + ".png"));
    }
	public void SetHead(Image desImage, string userName)
	{
		AccountSaveData data = XMLSaver.saveData.GetAccountData(userName);
        SetHead(desImage, data.accountId);
	}
    public void SetHead(Image desImage)
    {
        SetHead(desImage, GameManager.Instance.curUserId);
    }
    #endregion

    #region 背景
    public void SetBack(Image desImage, int userId)
    {
        if (_backSpriteDict.ContainsKey(userId))
        {
            desImage.sprite = _backSpriteDict[userId];
            return;
        }
        AccountSaveData data = XMLSaver.saveData.GetAccountData(userId);
        if (string.IsNullOrEmpty(data.backSprite))
        {
            SetHead(desImage, userId);
            return;
        }
        if (data.backSprite.IndexOf(_systemBackIdent) == 0)
        {
            Sprite sprite = Resources.Load<Sprite>(data.backSprite);
            if (sprite == null)
                SetHead(desImage, userId);
            else
            {
                desImage.sprite = sprite;
                _backSpriteDict.Add(data.accountId, sprite);
            }
            return;
        }
        StartCoroutine(GetBackTexture(userId, desImage, _backPath + data.backSprite + ".png"));
    }
    public void SetBack(Image desImage, string userName)
    {
        AccountSaveData data = XMLSaver.saveData.GetAccountData(userName);
        SetBack(desImage, data.accountId);
    }
    public void SetBack(Image desImage)
    {
        SetBack(desImage, GameManager.Instance.curUserId);
    }
    #endregion

    private IEnumerator GetHeadTexture(int userId, Image image, string url)
    {
        WWW wwwTexture = new WWW("file://" + url);
        yield return wwwTexture;
        if (wwwTexture.isDone && wwwTexture.texture != null)
        {
            Sprite sprite = Sprite.Create(wwwTexture.texture, new Rect(0, 0, wwwTexture.texture.width, wwwTexture.texture.height), Vector2.zero);
            if (sprite == null)
            {
                sprite = _defaultSprite;
            }
            if (_headSpriteDict.ContainsKey(userId))
                _headSpriteDict[userId] = sprite;
            else
                _headSpriteDict.Add(userId, sprite);
            image.sprite = sprite;
        }
    }

    private IEnumerator GetBackTexture(int userId, Image image, string url)
    {
        WWW wwwTexture = new WWW("file://" + url);
        yield return wwwTexture;
        if (wwwTexture.isDone && wwwTexture.texture != null)
        {
            Sprite sprite = Sprite.Create(wwwTexture.texture, new Rect(0, 0, wwwTexture.texture.width, wwwTexture.texture.height), Vector2.zero);
            if (sprite == null)
            {
                SetHead(image, userId);
            }
            else
            {
                if (_backSpriteDict.ContainsKey(userId))
                    _backSpriteDict[userId] = sprite;
                else
                    _backSpriteDict.Add(userId, sprite);
                image.sprite = sprite;
            }
        }
    }

    #region 选择图片上传
    public void Clear()
    {
        _uploadTexture = null;
        _uploadSprite = null;
        _loading = false;
    }

    public void UploadTexture(Image image)
    {
        OpenFileName ofn = new OpenFileName();
        ofn.structSize = Marshal.SizeOf(ofn);
        ofn.filter = "All Files\0*.*\0\0";
        ofn.file = new string(new char[256]);
        ofn.maxFile = ofn.file.Length;
        ofn.fileTitle = new string(new char[64]);
        ofn.maxFileTitle = ofn.fileTitle.Length;
        ofn.initialDir = UnityEngine.Application.dataPath;//默认路径  
        ofn.title = ContentHelper.Read(ContentHelper.SelectHeadText);
        ofn.defExt = "JPG";//显示文件的类型  
                           //注意 以下项目不一定要全选 但是0x00000008项不要缺少  
        ofn.flags = 0x00080000 | 0x00001000 | 0x00000800 | 0x00000200 | 0x00000008;//OFN_EXPLORER|OFN_FILEMUSTEXIST|OFN_PATHMUSTEXIST| OFN_ALLOWMULTISELECT|OFN_NOCHANGEDIR  
        if (WindowDll.GetOpenFileName(ofn))
        {
            _uploadTexture = null;
            _uploadSprite = null;
            StartCoroutine(GetUploadTexture(ofn.file, image));
        }
    }

    private IEnumerator GetUploadTexture(string url, Image image)
    {
        _loading = true;
        WWW wwwTexture = new WWW("file://" + url);
        yield return wwwTexture;
        if (wwwTexture.isDone)
        {
            {
                _uploadTexture = wwwTexture.texture;
                if (_uploadTexture.width != _uploadTexture.height)
                {
                    Texture2D desTexture = null;
                    Color[] desColors;
                    if (_uploadTexture.width > _uploadTexture.height)
                    {
                        desTexture = new Texture2D(_uploadTexture.height, _uploadTexture.height);
                        desColors = _uploadTexture.GetPixels((_uploadTexture.width - _uploadTexture.height) / 2, 0,
                            _uploadTexture.height, _uploadTexture.height);
                    }
                    else
                    {
                        desTexture = new Texture2D(_uploadTexture.width, _uploadTexture.width);
                        desColors = _uploadTexture.GetPixels(0, (_uploadTexture.height - _uploadTexture.width) / 2,
                            _uploadTexture.width, _uploadTexture.width);
                    }
                    desTexture.SetPixels(desColors);
                    desTexture.Apply();
                    _uploadTexture = desTexture;
                }
                _uploadSprite = Sprite.Create(_uploadTexture, new Rect(0, 0, _uploadTexture.width, _uploadTexture.height), Vector2.zero);
                image.sprite = _uploadSprite;
            }
            _loading = false;
        }
    }
    #endregion

    #region 保存到本地
    public void SaveHeadTexture()
    {
        if (!_loading && _uploadTexture != null && _uploadSprite != null)
        {
            string pngName = GameManager.Instance.curEnName + "_head";
            if (SaveRenderTextureToPNG(_uploadTexture, _outputShader, _headPath + _customIdent, pngName))
            {
                GameManager.Instance.accountData.headSprite = _customIdent + pngName;
                _headSpriteDict[GameManager.Instance.curUserId] = _uploadSprite;
            }
        }
    }

    public void SaveBackTexture()
    {
        if (!_loading && _uploadTexture != null && _uploadSprite != null)
        {
            string pngName = GameManager.Instance.curEnName + "_back";
            if (SaveRenderTextureToPNG(_uploadTexture, _outputShader, _backPath + _customIdent, pngName))
            {
                GameManager.Instance.accountData.backSprite = _customIdent + pngName;
                _backSpriteDict[GameManager.Instance.curUserId] = _uploadSprite;
            }
        }
    }

    private bool SaveRenderTextureToPNG(Texture inputTex, Shader outputShader, string contents, string pngName)
    {
        RenderTexture temp = RenderTexture.GetTemporary(inputTex.width, inputTex.height, 0, RenderTextureFormat.ARGB32);
        Material mat = new Material(outputShader);
        Graphics.Blit(inputTex, temp, mat);
        bool ret = SaveRenderTextureToPNG(temp, contents, pngName);
        RenderTexture.ReleaseTemporary(temp);
        _uploadTexture = null;
        return ret;
    }

    private bool SaveRenderTextureToPNG(RenderTexture rt, string contents, string pngName)
    {
        RenderTexture prev = RenderTexture.active;
        RenderTexture.active = rt;
        Texture2D png = new Texture2D(rt.width, rt.height, TextureFormat.ARGB32, false);
        png.ReadPixels(new Rect(0, 0, rt.width, rt.height), 0, 0);
        byte[] bytes = png.EncodeToPNG();
        if (!Directory.Exists(contents))
            Directory.CreateDirectory(contents);
        FileStream file = File.Open(contents + pngName + ".png", FileMode.Create);
        BinaryWriter writer = new BinaryWriter(file);
        writer.Write(bytes);
        file.Close();
        Texture2D.DestroyImmediate(png);
        png = null;
        RenderTexture.active = prev;
        return true;
    }
    #endregion
}

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
public class OpenFileName
{
    public int structSize = 0;
    public IntPtr dlgOwner = IntPtr.Zero;
    public IntPtr instance = IntPtr.Zero;
    public String filter = null;
    public String customFilter = null;
    public int maxCustFilter = 0;
    public int filterIndex = 0;
    public String file = null;
    public int maxFile = 0;
    public String fileTitle = null;
    public int maxFileTitle = 0;
    public String initialDir = null;
    public String title = null;
    public int flags = 0;
    public short fileOffset = 0;
    public short fileExtension = 0;
    public String defExt = null;
    public IntPtr custData = IntPtr.Zero;
    public IntPtr hook = IntPtr.Zero;
    public String templateName = null;
    public IntPtr reservedPtr = IntPtr.Zero;
    public int reservedInt = 0;
    public int flagsEx = 0;
}

public class WindowDll
{
    [DllImport("Comdlg32.dll", SetLastError = true, ThrowOnUnmappableChar = true, CharSet = CharSet.Auto)]
    public static extern bool GetOpenFileName([In, Out] OpenFileName ofn);
    public static bool GetOpenFileName1([In, Out] OpenFileName ofn)
    {
        return GetOpenFileName(ofn);
    }
}