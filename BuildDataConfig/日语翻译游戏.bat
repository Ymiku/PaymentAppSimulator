::���ܵ�����: �Զ������޸ĵ����ñ���
::��Ҫ��װsvn�����У�������Ч
cd /d %~dp0
cd ..
svn revert --depth infinity .
svn update --depth infinity .
cd /d %~dp0

python translate\translate.py
python build_all.py
pause