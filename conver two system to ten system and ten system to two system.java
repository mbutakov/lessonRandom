import java.util.Scanner;

public class Main {
    
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);
        System.out.println("Выберите тип перевода из  1)10в2 или из 2)2в10. ");
        String numberTwo = "";
        if(scan.nextInt() == 1){
            System.out.println("Введите число для перевода из 10 в 2 ");
            int number = scan.nextInt();
            numberTwo = Integer.toBinaryString(number);
        }else{
            System.out.println("Введите число для перевода из 2 в 10 ");
            int number = scan.nextInt();
            numberTwo = Integer.parseInt(Integer.toString(number), 2) + "";
        }
        System.out.println(Integer.parseInt(numberTwo));
    }
}
