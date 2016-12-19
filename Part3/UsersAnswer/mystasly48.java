import java.util.*;
public class Part3 {
  public static void main(String[] args) throws Exception {
    Scanner sc = new Scanner(System.in);
    sc.nextLine(); // ignore
    String line = sc.nextLine();
    String[] values = line.split(" ", 0);
    int result = 0;
    for (int i = 0; i < values.length; i++) {
      result += Integer.parseInt(values[i]);
    }
    result *= 1.08;
    System.out.println(result);
  }
}
