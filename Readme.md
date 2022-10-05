# NPI Validator
## Summary
NPI Validator (NPIValidate.exe) is a command line program that takes an NPI ID as an input argument and outputs "True" if the NPI ID is valid and "False" if it is not.

NPI Validator performs validation checks on input to determine if the ID is 10 digits and if it validates against the Luhn algorithm. NPI ID's are validated against the Luhn algorithm by first prefixing them with the digits `80840`.

This program is intended for use with HL7 integration engines such as Corepoint

## Usage
Validating an NPI:  
```cmd
C:\> NPIValidate.exe 1003206169
False
```

```cmd
C:\> NPIValidate.exe 1144770041
True
```