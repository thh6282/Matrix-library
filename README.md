﻿# Matrix-library

Program overview:
The program is written in C# language
The matrix library includes operations: multiplying a matrix by a number, adding a matrix, subtracting a matrix, multiplying a matrix, transposing a matrix, determining a matrix.

Program structure:
The program is divided into 8 modules:
## 1. Calculate the matrix multiplied by 1 number
   n is the number of the first dimension of the matrix, m is the number of the second dimension of the matrix
   The loop runs from 0 to n-1 loops from 0 to m-1:
    ```
    kA = A[i, j] * k
    ```
## 2. Calculate addition of 2 matrices
   Two matrices can only be added if they have the same size

   
   If two matrices are not the same size, print a message (in main function)

   
   n is the number of the first dimension of the matrix, m is the number of the second dimension of the matrix

   
   The loop runs from 0 to n-1 loops from 0 to m-1:
   ```
   A+B = A[i, j] + B[i, j]
   ```
## 3. Compute and subtract 2 matrices
  Two matrices can only be subtracted if they are the same size. If two matrices are not the same size, print a message (in main function).  n is the number of the first dimension of the matrix, m is the number 
  of the second dimension of the matrix. The loop runs from 0 to n-1 loops from 0 to m-1:
  ```
  A+B = A[i, j] - B[i, j]
  ```
  
## 4. Calculate the multiplication of 2 matrices
  n is the first dimension, m is the second dimension of matrix A. p is the first dimension, q is the second dimension of matrix B


  Loop runs from 0 to n-1, loop from 0 to m-1, loop from 0 to m-1:
  ```
  C[i, j] += A[i, k] * B[k, j]
  ```
## 5. Matrix transposition
  Write the rows of A into columns of A^T


  Write the columns of A into rows of A^T

  
  Loop for i from 0 to n, j from 0 to m:
  ```
  A_t[i, j] = A[j, i]
  ```
## 6. Calculate the determinant of the matrix  The determinant is only defined in square matrices
  If it is a 1x1 matrix, the determinant is the only element of the matrix which is A[1, 1]
  If the matrix is a θ matrix of size n, then the determinant is 0
  Calculate the determinant of the k-level sub-determinant:
   ```
   A_{ij}=(-1)^(ⅈ+j) |M_{ij}|
   ```
  Use recursion to call each k-level subdeterminant to calculate det A
   ```
   det A= a_{1j}.A_{1j}+⋯+a_{nj}.A_{nj}
   ```
## 7. The function inputs the matrix from the keyboard
  Enter the number of rows and columns. Loop for i from 0 to row number, j from 0 to column number


  Enter the elements A[i, j] one after another

## 8. The function prints the matrix to the screen
  Check the number of rows and columns of the matrix to print


  Loop for i from 0 to row number, j from 0 to column number  

  
  Print out the elements A[i, j] one after another


  
