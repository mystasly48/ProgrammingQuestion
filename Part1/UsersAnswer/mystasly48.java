import java.util.*;
public class Part1 {
  public static void main(String[] args) throws Exception {
    Scanner sc = new Scanner(System.in);
    String line = sc.nextLine();
    String[] values = line.split(" ", 0);
    int result = 0;
    for (int i = 0; i < values.length; i++) {
      result += Integer.parseInt(values[i]);
    }
    System.out.println(result);
  }
}
