import sys, struct, pefile
pe = pefile.PE(sys.argv[1], fast_load=True)
for a in sys.argv[2:]:
    va, kind = a.split(':'); rva = int(va,16) - 0x180000000
    b = pe.get_data(rva, 8)
    print(va, kind, struct.unpack('<f', b[:4])[0] if kind=='f' else struct.unpack('<d', b)[0])
