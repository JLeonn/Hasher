# Hasher

Hashes each password in a given .txt file and stores each property of the hash into a .hash File.

The application comes with a simplistic interface in order to guide you through
the process of hashing your desired passwords.

![alt tag](exmaples/main-window.png)

Steps:
1. Select the target file.
2. Select the desired hashing algorithm.
3. Determine salt properties.
4. Go.

Each line of the targeted file will be hashed and written to a new file.

Supported Hashing Algorithms: SHA512, SHA384, SHA256, SHA1
