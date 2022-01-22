/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package com.mycompany.java_class_project;
import java.util.Scanner;

/**
 *
 * @author MikeChuv
 */
class Matrix{
    double[][] matr;
    Scanner sc;
    Matrix(int n, int m){
        matr = new double[n][m];
        sc = new Scanner(System.in);
    }
    void input(){
        for (int i = 0; i < matr.length; ++i){
            for (int j = 0; j < matr[i].length; ++j){
                System.out.println("Matrix["+i+","+j+"] = ");
                matr[i][j] = sc.nextDouble();
                //System.out.println();
            }
        }
    }
    void output(){
        for (int i = 0; i < matr.length; ++i){
            for (int j = 0; j < matr[i].length; ++j){
                //System.out.print(matr[i][j] + " ");
                System.out.format("%f" , matr[i][j]);
            }
            System.out.println();
        }
    }

}



class Array{
    double[] arr;
    Scanner sc;
    Array(int n){
        arr = new double[n];
        sc = new Scanner(System.in);
    }
    void input(){
        for (int i = 0; i < arr.length; ++i){
            System.out.println("Array["+i+"] = ");
            arr[i] = sc.nextDouble();
            //System.out.println();
        }
    }
    void output(){
        System.out.println("Array:");
        for (int i = 0; i < arr.length; ++i){
            //System.out.print(arr[i] + " ");
            System.out.format("%5.3f\t" , arr[i]);
        }
        System.out.println();
    }
    
    boolean hasEquals(){
        if (arr.length <= 1){
            return false;
        }
        for (int i = 0; i < arr.length; ++i) {
            for (int j = i+1; j < arr.length; ++j) {
                if(arr[i] == arr[j]) return true;
            }
        }
        return false;
    }
    
    void addSumMatrRow(Matrix matr){
        for (int i = 0; i < arr.length; ++i){
            double sum = 0;
            for (int j = 0; j < matr.matr[i].length; ++j){
                sum += matr.matr[i][j];
            }
            arr[i] += sum;
        }
    }

}

public class ArrayMain {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner sc = new Scanner(System.in);
        System.out.println("Array length = ");
        int arrLength = sc.nextInt();
        Array arr = new Array(arrLength);
        arr.input();
        
//        System.out.println("Matrix rows = ");
//        int matn = sc.nextInt();
        System.out.println("Matrix cols = ");
        int matm = sc.nextInt();
        Matrix matr = new Matrix(arrLength, matm);
        matr.input();
        if (arr.hasEquals()){
            arr.addSumMatrRow(matr);
        }
        arr.output();
    }
    
}
