using System;
public class Hello {
  public static void Main() {
    string s = Console.ReadLine();
    string t = Console.ReadLine();
    string[] s_a = s.Split(' ');
    string[] t_a = t.Split(' ');
    int[] s_i = new int[s_a.Length];
    int[] t_i = new int[t_a.Length];
    for (int i = 0; i < s_i.Length; i++) {
      s_i[i] = int.Parse(s_a[i]);
    }
    for (int i = 0; i < t_i.Length; i++) {
      t_i[i] = int.Parse(t_a[i]);
    }
    DateTime s_t = new DateTime(s_i[0], s_i[1], s_i[2], s_i[3], s_i[4], s_i[5]);
    DateTime t_t = new DateTime(t_i[0], t_i[1], t_i[2], t_i[3], t_i[4], t_i[5]);
    TimeSpan diff_t = t_t - s_t;
    double diff_h_d = diff_t.TotalHours;
    int diff_h_i = (int)Math.Ceiling(diff_h_d);
    Console.WriteLine(diff_h_i);
  }
}