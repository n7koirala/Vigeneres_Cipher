# Guide for navigating the HEProfiler test data folders

Data for the HEProfiler is categorized using the machine architectures.

1. `avx2`: Contains tests run on Advanced Vector Extensions 2 (AVX2) architecture
2. `avx512`: Contains tests run on Advanced Vector Extensions SIMD instructions for x86 instruction set architecture
3. `HEAAN_GPU_avx2`: Contains tests run on Advanced Vector Extensions 2 (AVX2) architecture using GPU for HEAAN only
4. `HEAAN_GPU_avx512`: Contains tests run on Advanced Vector Extensions SIMD instructions for x86 instruction set architecture using GPU for HEAAN only

- Folders are named using the type of test data that they contain
- report.csv file contains the actual data used for all the graphs

# How to read the report.csv file

- First column contains the type of test run (For instance, HEAANProfiler refers to tests run using HEAAN as a backend library)
- Second column refers to the type of test ran (add refers to addition test, mult refers to multiplication test etc.)
- Third column contains the numbers for tests on the second column. Runtimes are in nanoseconds and error is calculated using the formula discussed in the paper.
- Fourth column refers to the standard deviation of the numbers in the third column 

## Somewhat Homomorphic Encryption (SHE) tests

 `avx2/SHE_tests`, `avx512/SHE_tests`, `HEAAN_GPU_avx2/SHE_tests`, `HEAAN_GPU_avx512/SHE_tests` : Contain tests run with somewhat homomorphic encryption (SHE) presets 

- `avx2/SHE_tests/Depth`, `avx512/SHE_tests/Depth`, `HEAAN_GPU_avx2/SHE_tests/Depth`, `HEAAN_GPU_avx512/SHE_tests/Depth`: Contain data for tests run using different depth levels for SHE 
- `avx2/SHE_tests/Dot`, `avx512/SHE_tests/Dot`, `HEAAN_GPU_avx2/SHE_tests/Dot`, `HEAAN_GPU_avx512/SHE_tests/Dot`: Contain data for dot product tests run using SHE presets
- `avx2/SHE_tests/Linear`, `avx512/SHE_tests/Linear`, `HEAAN_GPU_avx2/SHE_tests/Linear`, `HEAAN_GPU_avx512/SHE_tests/Linear`: Contain data for linear transformation tests run using SHE presets
- `avx2/SHE_tests/Polyeval`, `avx512/SHE_tests/Polyeval`, `HEAAN_GPU_avx2/SHE_tests/Polyeval`, `HEAAN_GPU_avx512/SHE_tests/Polyeval`: Contains data for polynomial evaluation tests run using SHE presets
- `avx2/SHE_tests/Polyeval/Polyeval_palisade', `avx512/SHE_tests/Polyeval/Polyeval_palisade': Contains data for polynomial evaluation tests run using native function of polynomial evaluation in PALISADE for SHE presets
- `avx2/SHE_tests/Threads`, `HEAAN_GPU_avx2/SHE_tests/Threads`, `HEAAN_GPU_avx512/SHE_tests/Threads`: Contains data for tests run using multiple threads using SHE presets (avx512 ommited due to similarity in numbers compared to avx2)
- `avx2/SHE_tests/Cipher_Plain_depth`, `avx512/SHE_tests/Cipher_Plain_depth` : Contains data for ciphertext-plaintext operations for tests run using different depth levels for SHE (this test not run for HEAAN_GPU_avx2 and HEAAN_GPU_avx512) 

## Fully Homomorphic Encryption (FHE) tests

`avx2/FHE_tests`, `avx512/FHE_tests`, `HEAAN_GPU_avx2/FHE_tests`, `HEAAN_GPU_avx512/FHE_tests`: Contains data for tests run using fully homomorphic encryption (FHE) presets (only HEAAN and PALISADE) 

- `avx2/FHE_tests/HEAAN`: Contains data for FHE tests run using HEAAN library for avx2
	- `avx2/FHE_tests/HEAAN/bootstrappingChainHEAAN`: Contains data for homomorphic chain multiplication tests run using FHE presets
	- `avx2/FHE_tests/HEAAN/bootstrappingHEAAN`: Contains data for homomorphic addition, multiplication, rotation, linear transformation, dot product, polynomial evaluation and bootstrapping timing tests run using FHE presets for HEAAN 

- `avx2/FHE_tests/PALISADE`: Contains data for FHE tests run using PALISADE library for avx2
	- `avx2/FHE_tests/PALISADE/bootstrappingPALISADE`: Contains data for homomorphic addition, multiplication, rotation and bootstrapping timing tests run using FHE presets for PALISADE

- `avx2/FHE_tests/HEAAN+PALISADE`: Contains data for FHE tests run using HEAAN and PALISADE library for avx2
	- `avx2/FHE_tests/HEAAN+PALISADE/bootstrapping`: Contains data for bootstrapping timing tests run using FHE presets for PALISADE and HEAAN
	- `avx2/FHE_tests/HEAAN+PALISADE/bootstrappingPlaintext`: Contains data for ciphertext-plaintext addition and multiplication tests run using FHE presets for PALISADE and HEAAN
	- `avx2/FHE_tests/HEAAN+PALISADE/threadsNew`: Contains data for bootstrapping timing tests run using multiple threads for FHE presets in PALISADE and HEAAN


- `avx512/FHE_tests/HEAAN/`: Contains data for homomorphic addition, multiplication, rotation, linear transformation, dot product, polynomial evaluation and bootstrapping timing tests run using FHE presets for HEAAN on avx512

- `avx512/FHE_tests/PALISADE/`: Contains data for FHE tests run using PALISADE library for avx512
	- `avx512/FHE_tests/PALISADE/bootstrappingPALISADE_Primitive` : Contains data for primitive operations such as addition, multiplication and rotation tests run using FHE presets in PALISADE
	- `avx512/FHE_tests/PALISADE/bootstrappingPALISADE_LinPoly` : Contains data for homomorphic linear transformation and polynomial evalutation test run using FHE presets in PALISADE
	- `avx512/FHE_tests/PALISADE/bootstrappingPALISADE_Dot` : Contains data for homomorphic dot product test run using FHE presets in PALISADE
	- `avx512/FHE_tests/PALISADE/bootstrappingPALISADE` : Contains data for bootstrapping timing test run using FHE presets in PALISADE

- `avx512/FHE_tests/HEAAN+PALISADE`: Contains data for FHE tests run using HEAAN and PALISADE library for avx512
	- `avx512/FHE_tests/HEAAN+PALISADE/bootstrappingPlaintext`: Contains data for ciphertext-plaintext addition and multiplication tests run using FHE presets for PALISADE and HEAAN 
	- `avx512/FHE_tests/HEAAN+PALISADE/Threads`: Contains data for bootstrapping timing tests run using multiple threads for FHE presets in PALISADE and HEAAN 
	- `avx512/FHE_tests/HEAAN+PALISADE/Bootstrapping`: Contains data for bootstrap timing tests for PALISADE and HEAAN 


- `HEAAN_GPU_avx2/FHE_tests/bootstrappingHEAAN_GPU`: Contains data for primitive level tests and bootstrapping timing test run using FHE presets in HEAAN using GPU on avx2

- `HEAAN_GPU_avx512/FHE_tests/bootstrappingHEAAN_GPU`: Contains data for primitive level tests and bootstrapping timing test run using FHE presets in HEAAN using GPU on avx512