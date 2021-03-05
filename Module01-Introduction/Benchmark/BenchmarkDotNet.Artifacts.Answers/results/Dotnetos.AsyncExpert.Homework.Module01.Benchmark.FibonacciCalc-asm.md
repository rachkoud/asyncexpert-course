## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       cmp       rsi,1
       je        short M00_L00
       cmp       rsi,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       lea       rdx,[rsi+0FFFE]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       mov       rbx,rax
       lea       rdx,[rsi+0FFFF]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       add       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 76
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       cmp       rsi,1
       je        short M00_L00
       cmp       rsi,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       add       rsp,20
       pop       rsi
       ret
M00_L01:
       test      rsi,rsi
       jl        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt64[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       ecx,[rax+8]
       cmp       ecx,0
       jbe       short M00_L03
       mov       qword ptr [rax+10],1
       cmp       ecx,1
       jbe       short M00_L03
       mov       qword ptr [rax+18],1
       mov       rcx,rsi
       mov       rdx,rax
       mov       rax,offset Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemo(UInt64, UInt64[])
       add       rsp,20
       pop       rsi
       jmp       rax
M00_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 119
```
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemo(UInt64, UInt64[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rdx
       lea       rdi,[rcx+0FFFF]
       lea       rbx,[rdi+0FFFF]
       lea       rcx,[rbx+0FFFF]
       test      rcx,rcx
       jl        near ptr M01_L02
       mov       rbp,rcx
       mov       ecx,[rsi+8]
       movsxd    r14,ecx
       cmp       rbp,r14
       jae       short M01_L03
       cmp       qword ptr [rsi+rbp*8+10],0
       jne       short M01_L00
       mov       r15,rbp
       mov       rcx,rbx
       mov       rdx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemo(UInt64, UInt64[])
       mov       [rsi+r15*8+10],rax
M01_L00:
       test      rbx,rbx
       jl        short M01_L02
       cmp       rbx,r14
       jae       short M01_L03
       cmp       qword ptr [rsi+rbx*8+10],0
       jne       short M01_L01
       mov       r15,rbx
       mov       rcx,rdi
       mov       rdx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemo(UInt64, UInt64[])
       mov       [rsi+r15*8+10],rax
M01_L01:
       test      rdi,rdi
       jl        short M01_L02
       mov       rax,rdi
       mov       rdx,rax
       mov       rcx,[rsi+rbp*8+10]
       add       rcx,[rsi+rbx*8+10]
       cmp       rdx,r14
       jae       short M01_L03
       mov       [rsi+rdx*8+10],rcx
       mov       rax,[rsi+rax*8+10]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 175
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Iterative(UInt64)
       cmp       rdx,1
       je        short M00_L00
       cmp       rdx,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       ret
M00_L01:
       mov       eax,1
       mov       ecx,1
       mov       r8d,2
       cmp       rdx,2
       jbe       short M00_L05
M00_L02:
       add       rax,rcx
       inc       r8
       cmp       r8,rdx
       jb        short M00_L04
M00_L03:
       ret
M00_L04:
       xchg      rax,rcx
       jmp       short M00_L02
M00_L05:
       mov       rax,rcx
       jmp       short M00_L03
; Total bytes of code 62
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       cmp       rsi,1
       je        short M00_L00
       cmp       rsi,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       lea       rdx,[rsi+0FFFE]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       mov       rbx,rax
       lea       rdx,[rsi+0FFFF]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       add       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 76
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       cmp       rsi,1
       je        short M00_L00
       cmp       rsi,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       add       rsp,20
       pop       rsi
       ret
M00_L01:
       test      rsi,rsi
       jl        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt64[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       ecx,[rax+8]
       cmp       ecx,0
       jbe       short M00_L03
       mov       qword ptr [rax+10],1
       cmp       ecx,1
       jbe       short M00_L03
       mov       qword ptr [rax+18],1
       mov       rcx,rsi
       mov       rdx,rax
       mov       rax,offset Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemo(UInt64, UInt64[])
       add       rsp,20
       pop       rsi
       jmp       rax
M00_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 119
```
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemo(UInt64, UInt64[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rdx
       lea       rdi,[rcx+0FFFF]
       lea       rbx,[rdi+0FFFF]
       lea       rcx,[rbx+0FFFF]
       test      rcx,rcx
       jl        near ptr M01_L02
       mov       rbp,rcx
       mov       ecx,[rsi+8]
       movsxd    r14,ecx
       cmp       rbp,r14
       jae       short M01_L03
       cmp       qword ptr [rsi+rbp*8+10],0
       jne       short M01_L00
       mov       r15,rbp
       mov       rcx,rbx
       mov       rdx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemo(UInt64, UInt64[])
       mov       [rsi+r15*8+10],rax
M01_L00:
       test      rbx,rbx
       jl        short M01_L02
       cmp       rbx,r14
       jae       short M01_L03
       cmp       qword ptr [rsi+rbx*8+10],0
       jne       short M01_L01
       mov       r15,rbx
       mov       rcx,rdi
       mov       rdx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemo(UInt64, UInt64[])
       mov       [rsi+r15*8+10],rax
M01_L01:
       test      rdi,rdi
       jl        short M01_L02
       mov       rax,rdi
       mov       rdx,rax
       mov       rcx,[rsi+rbp*8+10]
       add       rcx,[rsi+rbx*8+10]
       cmp       rdx,r14
       jae       short M01_L03
       mov       [rsi+rdx*8+10],rcx
       mov       rax,[rsi+rax*8+10]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 175
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Iterative(UInt64)
       cmp       rdx,1
       je        short M00_L00
       cmp       rdx,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       ret
M00_L01:
       mov       eax,1
       mov       ecx,1
       mov       r8d,2
       cmp       rdx,2
       jbe       short M00_L05
M00_L02:
       add       rax,rcx
       inc       r8
       cmp       r8,rdx
       jb        short M00_L04
M00_L03:
       ret
M00_L04:
       xchg      rax,rcx
       jmp       short M00_L02
M00_L05:
       mov       rax,rcx
       jmp       short M00_L03
; Total bytes of code 62
```

