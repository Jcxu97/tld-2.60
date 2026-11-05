import UnityPy, os, sys, json
root=r"D:\Steam\steamapps\common\TheLongDark\tld_Data\StreamingAssets\aa\StandaloneWindows64"
out={}
files=sorted(f for f in os.listdir(root) if f.endswith('.bundle'))
for f in files:
    p=os.path.join(root,f)
    try: env=UnityPy.load(p)
    except Exception as e: continue
    cont={}
    for obj in env.objects:
        if obj.type.name=='AssetBundle':
            try:
                d=obj.read_typetree()
                for path,info in d.get('m_Container',[]):
                    if path.endswith('.prefab'): cont[info['asset']['m_PathID']]=path
            except Exception: pass
    if not cont: continue
    hit=0
    for obj in env.objects:
        if obj.type.name!='MonoBehaviour': continue
        try: d=obj.read_typetree()
        except Exception: continue
        if 'm_AllowInInventory' in d and 'm_DecorationPrefab' in d:
            go=d['m_GameObject']['m_PathID']
            if go in cont:
                dn=d.get('m_DisplayName',{})
                out[cont[go]]=dict(loc=dn.get('m_LocalizationID',''),inv=d['m_AllowInInventory'],w=d.get('m_Weight'))
                hit+=1
    print(f,len(cont),hit,file=sys.stderr,flush=True)
json.dump(out,open(sys.argv[1],'w',encoding='utf-8'),ensure_ascii=False,indent=0)
print(len(out))
