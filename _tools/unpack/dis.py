import sys, pefile, capstone
pe = pefile.PE(sys.argv[1], fast_load=True)
md = capstone.Cs(capstone.CS_ARCH_X86, capstone.CS_MODE_64)
for a in sys.argv[2:]:
    rva, n = a.split(':'); rva=int(rva,16); n=int(n,16)
    data = pe.get_data(rva, n)
    print('=== %x' % rva)
    for i in md.disasm(data, 0x180000000+rva):
        print('%x %s %s' % (i.address, i.mnemonic, i.op_str))
