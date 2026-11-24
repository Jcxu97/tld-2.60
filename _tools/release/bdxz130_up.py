# V13.0 Baidu: upload the MoreBunkers v1.5 zip into 3_功能mods 选装. Run bdxz130_prep.py first.
import sys
sys.path.insert(0, r'D:\Github\tld--2.55\_tools\release')
import release as R, baidu_upload as B

MB = r'C:\Users\82077\Desktop\TLD\零散MODS\MoreBunkers-v1.5_更多地堡三个新地堡_适配2.60_解压到游戏根目录.zip'
R.net_folders = lambda v: {'xz': ('', '3_功能mods 选装', [])}
R.upload_targets = lambda keys: [('xz', [MB])]
B.main()
