## .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
```assembly
; BenchmarkFSharp.Benchmarks+FibonacciCalcFSharp.RecursiveMemoized(UInt64)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<UInt64>)
       mov       rcx,rdi
       mov       edx,1
       mov       r8d,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]].TryInsert(UInt64, UInt64, System.Collections.Generic.InsertionBehavior)
       mov       rcx,rdi
       mov       edx,2
       mov       r8d,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]].TryInsert(UInt64, UInt64, System.Collections.Generic.InsertionBehavior)
       mov       rcx,rdi
       mov       rdx,rsi
       mov       rax,offset BenchmarkFSharp.Benchmarks.go@21(System.Collections.Generic.Dictionary`2<UInt64,UInt64>, UInt64)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 115
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<UInt64>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,r8
       test      edx,edx
       jl        short M01_L02
       test      edx,edx
       jle       short M01_L00
       mov       rcx,rdi
       call      System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]].Initialize(Int32)
M01_L00:
       mov       rdx,246F0382D58
       cmp       rsi,[rdx]
       je        short M01_L01
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,16
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 74
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]].TryInsert(UInt64, UInt64, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M02_L00
       mov       rcx,rsi
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]].Initialize(Int32)
M02_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       je        short M02_L01
       mov       rcx,r15
       mov       rdx,rdi
       mov       r11,7FFE16DA03F8
       cmp       [rcx],ecx
       call      qword ptr [7FFE171303F8]
       mov       r12d,eax
       jmp       short M02_L02
M02_L01:
       mov       rax,rdi
       shr       rax,20
       mov       r12d,eax
       xor       r12d,edi
M02_L02:
       xor       r13d,r13d
       mov       rcx,[rsi+8]
       mov       r8,rcx
       mov       eax,r12d
       xor       edx,edx
       div       dword ptr [rcx+8]
       cmp       edx,[r8+8]
       jae       near ptr M02_L22
       movsxd    rax,edx
       lea       r9,[r8+rax*4+10]
       mov       r10d,[r9]
       dec       r10d
       test      r15,r15
       jne       short M02_L08
       mov       r15d,[r14+8]
M02_L03:
       cmp       r15d,r10d
       jbe       near ptr M02_L12
       movsxd    r10,r10d
       lea       rax,[r10+r10*2]
       lea       rdx,[r14+rax*8+10]
       cmp       [rdx+4],r12d
       jne       short M02_L04
       mov       rcx,[rdx+8]
       cmp       rcx,rdi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M02_L05
M02_L04:
       mov       r10d,[r14+rax*8+10]
       cmp       r15d,r13d
       jle       near ptr M02_L19
       inc       r13d
       jmp       short M02_L03
M02_L05:
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M02_L06
       mov       [rdx+10],rbx
       inc       dword ptr [rsi+3C]
       jmp       near ptr M02_L17
M02_L06:
       cmp       r13d,2
       je        near ptr M02_L18
M02_L07:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L08:
       mov       edx,[r14+8]
       mov       eax,edx
       mov       [rsp+3C],eax
       cmp       eax,r10d
       jbe       short M02_L09
       movsxd    rdx,r10d
       lea       r10,[rdx+rdx*2]
       mov       [rsp+40],r10
       lea       r11,[r14+r10*8+10]
       cmp       [r11+4],r12d
       jne       short M02_L11
       mov       [rsp+30],r9
       mov       [rsp+28],r11
       mov       rdx,[r11+8]
       mov       rcx,r15
       mov       r8,rdi
       mov       r11,7FFE16DA03F0
       cmp       [rcx],ecx
       call      qword ptr [7FFE171303F0]
       test      eax,eax
       mov       r9,[rsp+30]
       je        short M02_L11
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M02_L10
       mov       r13,[rsp+28]
       mov       [r13+10],rbx
       inc       dword ptr [rsi+3C]
       jmp       near ptr M02_L17
M02_L09:
       mov       r15d,[rsp+3C]
       jmp       short M02_L12
M02_L10:
       cmp       r13d,2
       je        near ptr M02_L20
       jmp       near ptr M02_L07
M02_L11:
       mov       r10,[rsp+40]
       mov       r10d,[r14+r10*8+10]
       mov       eax,[rsp+3C]
       cmp       eax,r13d
       jle       near ptr M02_L21
       inc       r13d
       jmp       near ptr M02_L08
M02_L12:
       xor       ebp,ebp
       mov       ecx,[rsi+38]
       test      ecx,ecx
       jle       short M02_L13
       mov       r13d,[rsi+34]
       mov       ebp,1
       dec       ecx
       mov       [rsi+38],ecx
       jmp       short M02_L15
M02_L13:
       mov       ecx,[rsi+30]
       mov       r13d,ecx
       cmp       r15d,r13d
       jne       short M02_L14
       call      System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[rsi+8]
       mov       r8,rcx
       mov       eax,r12d
       xor       edx,edx
       div       dword ptr [rcx+8]
       cmp       edx,[r8+8]
       jae       near ptr M02_L22
       movsxd    rax,edx
       lea       r9,[r8+rax*4+10]
       mov       r15,r9
       mov       r9,r15
M02_L14:
       lea       eax,[r13+1]
       mov       [rsi+30],eax
       mov       r14,[rsi+10]
M02_L15:
       mov       eax,[r14+8]
       cmp       r13d,eax
       jae       short M02_L22
       movsxd    rcx,r13d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       test      ebp,ebp
       je        short M02_L16
       mov       edx,[rsi+34]
       cmp       edx,eax
       jae       short M02_L22
       movsxd    rax,edx
       lea       rax,[rax+rax*2]
       mov       eax,[r14+rax*8+10]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rsi+34],eax
M02_L16:
       mov       [rcx+4],r12d
       mov       eax,[r9]
       dec       eax
       mov       [rcx],eax
       mov       [rcx+8],rdi
       mov       [rcx+10],rbx
       inc       r13d
       mov       [r9],r13d
       inc       dword ptr [rsi+3C]
M02_L17:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L18:
       mov       rcx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.UInt64, System.Private.CoreLib]](UInt64)
       int       3
M02_L19:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M02_L20:
       mov       rcx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.UInt64, System.Private.CoreLib]](UInt64)
       int       3
M02_L21:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M02_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 672
```
```assembly
; BenchmarkFSharp.Benchmarks.go@21(System.Collections.Generic.Dictionary`2<UInt64,UInt64>, UInt64)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rdi,rcx
       mov       rsi,rdx
       cmp       rsi,1
       jne       short M03_L01
M03_L00:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L01:
       cmp       rsi,2
       je        short M03_L00
       xor       r8d,r8d
       mov       [rsp+28],r8
       lea       r8,[rsp+28]
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE1712F3D0]
       test      eax,eax
       je        short M03_L02
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L02:
       lea       rdx,[rsi+0FFFF]
       mov       rcx,rdi
       call      BenchmarkFSharp.Benchmarks.go@21(System.Collections.Generic.Dictionary`2<UInt64,UInt64>, UInt64)
       mov       rbx,rax
       lea       rdx,[rsi+0FFFE]
       mov       rcx,rdi
       call      BenchmarkFSharp.Benchmarks.go@21(System.Collections.Generic.Dictionary`2<UInt64,UInt64>, UInt64)
       add       rbx,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]].TryInsert(UInt64, UInt64, System.Collections.Generic.InsertionBehavior)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```

## .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
```assembly
; BenchmarkFSharp.Benchmarks+FibonacciCalcFSharp.RecursiveMemoized(UInt64)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<UInt64>)
       mov       rcx,rdi
       mov       edx,1
       mov       r8d,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]].TryInsert(UInt64, UInt64, System.Collections.Generic.InsertionBehavior)
       mov       rcx,rdi
       mov       edx,2
       mov       r8d,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]].TryInsert(UInt64, UInt64, System.Collections.Generic.InsertionBehavior)
       mov       rcx,rdi
       mov       rdx,rsi
       mov       rax,offset BenchmarkFSharp.Benchmarks.go@21(System.Collections.Generic.Dictionary`2<UInt64,UInt64>, UInt64)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 115
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<UInt64>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,r8
       test      edx,edx
       jl        short M01_L02
       test      edx,edx
       jle       short M01_L00
       mov       rcx,rdi
       call      System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]].Initialize(Int32)
M01_L00:
       mov       rdx,17C10002D58
       cmp       rsi,[rdx]
       je        short M01_L01
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,16
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 74
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]].TryInsert(UInt64, UInt64, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M02_L00
       mov       rcx,rsi
       xor       edx,edx
       call      System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]].Initialize(Int32)
M02_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       je        short M02_L01
       mov       rcx,r15
       mov       rdx,rdi
       mov       r11,7FFE16DA03F8
       cmp       [rcx],ecx
       call      qword ptr [7FFE171303F8]
       mov       r12d,eax
       jmp       short M02_L02
M02_L01:
       mov       rax,rdi
       shr       rax,20
       mov       r12d,eax
       xor       r12d,edi
M02_L02:
       xor       r13d,r13d
       mov       rcx,[rsi+8]
       mov       r8,rcx
       mov       eax,r12d
       xor       edx,edx
       div       dword ptr [rcx+8]
       cmp       edx,[r8+8]
       jae       near ptr M02_L22
       movsxd    rax,edx
       lea       r9,[r8+rax*4+10]
       mov       r10d,[r9]
       dec       r10d
       test      r15,r15
       jne       short M02_L08
       mov       r15d,[r14+8]
M02_L03:
       cmp       r15d,r10d
       jbe       near ptr M02_L12
       movsxd    r10,r10d
       lea       rax,[r10+r10*2]
       lea       rdx,[r14+rax*8+10]
       cmp       [rdx+4],r12d
       jne       short M02_L04
       mov       rcx,[rdx+8]
       cmp       rcx,rdi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M02_L05
M02_L04:
       mov       r10d,[r14+rax*8+10]
       cmp       r15d,r13d
       jle       near ptr M02_L19
       inc       r13d
       jmp       short M02_L03
M02_L05:
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M02_L06
       mov       [rdx+10],rbx
       inc       dword ptr [rsi+3C]
       jmp       near ptr M02_L17
M02_L06:
       cmp       r13d,2
       je        near ptr M02_L18
M02_L07:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L08:
       mov       edx,[r14+8]
       mov       eax,edx
       mov       [rsp+3C],eax
       cmp       eax,r10d
       jbe       short M02_L09
       movsxd    rdx,r10d
       lea       r10,[rdx+rdx*2]
       mov       [rsp+40],r10
       lea       r11,[r14+r10*8+10]
       cmp       [r11+4],r12d
       jne       short M02_L11
       mov       [rsp+30],r9
       mov       [rsp+28],r11
       mov       rdx,[r11+8]
       mov       rcx,r15
       mov       r8,rdi
       mov       r11,7FFE16DA03F0
       cmp       [rcx],ecx
       call      qword ptr [7FFE171303F0]
       test      eax,eax
       mov       r9,[rsp+30]
       je        short M02_L11
       movzx     r13d,bpl
       cmp       r13d,1
       jne       short M02_L10
       mov       r13,[rsp+28]
       mov       [r13+10],rbx
       inc       dword ptr [rsi+3C]
       jmp       near ptr M02_L17
M02_L09:
       mov       r15d,[rsp+3C]
       jmp       short M02_L12
M02_L10:
       cmp       r13d,2
       je        near ptr M02_L20
       jmp       near ptr M02_L07
M02_L11:
       mov       r10,[rsp+40]
       mov       r10d,[r14+r10*8+10]
       mov       eax,[rsp+3C]
       cmp       eax,r13d
       jle       near ptr M02_L21
       inc       r13d
       jmp       near ptr M02_L08
M02_L12:
       xor       ebp,ebp
       mov       ecx,[rsi+38]
       test      ecx,ecx
       jle       short M02_L13
       mov       r13d,[rsi+34]
       mov       ebp,1
       dec       ecx
       mov       [rsi+38],ecx
       jmp       short M02_L15
M02_L13:
       mov       ecx,[rsi+30]
       mov       r13d,ecx
       cmp       r15d,r13d
       jne       short M02_L14
       call      System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[rsi+8]
       mov       r8,rcx
       mov       eax,r12d
       xor       edx,edx
       div       dword ptr [rcx+8]
       cmp       edx,[r8+8]
       jae       near ptr M02_L22
       movsxd    rax,edx
       lea       r9,[r8+rax*4+10]
       mov       r15,r9
       mov       r9,r15
M02_L14:
       lea       eax,[r13+1]
       mov       [rsi+30],eax
       mov       r14,[rsi+10]
M02_L15:
       mov       eax,[r14+8]
       cmp       r13d,eax
       jae       short M02_L22
       movsxd    rcx,r13d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+10]
       test      ebp,ebp
       je        short M02_L16
       mov       edx,[rsi+34]
       cmp       edx,eax
       jae       short M02_L22
       movsxd    rax,edx
       lea       rax,[rax+rax*2]
       mov       eax,[r14+rax*8+10]
       neg       eax
       add       eax,0FFFFFFFD
       mov       [rsi+34],eax
M02_L16:
       mov       [rcx+4],r12d
       mov       eax,[r9]
       dec       eax
       mov       [rcx],eax
       mov       [rcx+8],rdi
       mov       [rcx+10],rbx
       inc       r13d
       mov       [r9],r13d
       inc       dword ptr [rsi+3C]
M02_L17:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L18:
       mov       rcx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.UInt64, System.Private.CoreLib]](UInt64)
       int       3
M02_L19:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M02_L20:
       mov       rcx,rdi
       call      System.ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException[[System.UInt64, System.Private.CoreLib]](UInt64)
       int       3
M02_L21:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M02_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 672
```
```assembly
; BenchmarkFSharp.Benchmarks.go@21(System.Collections.Generic.Dictionary`2<UInt64,UInt64>, UInt64)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rdi,rcx
       mov       rsi,rdx
       cmp       rsi,1
       jne       short M03_L01
M03_L00:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L01:
       cmp       rsi,2
       je        short M03_L00
       xor       r8d,r8d
       mov       [rsp+28],r8
       lea       r8,[rsp+28]
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE1712F3D0]
       test      eax,eax
       je        short M03_L02
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L02:
       lea       rdx,[rsi+0FFFF]
       mov       rcx,rdi
       call      BenchmarkFSharp.Benchmarks.go@21(System.Collections.Generic.Dictionary`2<UInt64,UInt64>, UInt64)
       mov       rbx,rax
       lea       rdx,[rsi+0FFFE]
       mov       rcx,rdi
       call      BenchmarkFSharp.Benchmarks.go@21(System.Collections.Generic.Dictionary`2<UInt64,UInt64>, UInt64)
       add       rbx,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rbx
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]].TryInsert(UInt64, UInt64, System.Collections.Generic.InsertionBehavior)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 150
```

