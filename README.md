# PasswordVault
Uses Advanced Encryption Standard (AES) to safely store website login information locally. I wouldn't trust this yet, but I do consider this the first stable build.

## Build and Miscellaneous
Visual Studio will probably yell at you about needing a certain .NET installation. The encrypted file should be hanging out with the executable.

## Plans
I have quite a few plans for QoL features and standard implementations. 
Such as:
   - Cryptographically secure password generation
   - User settings pertaining to application use and behaviors
   - Form settings like auto-hide and keep-on-top
   - Extra salting and encryption of the factory, as it is currently just a hash
