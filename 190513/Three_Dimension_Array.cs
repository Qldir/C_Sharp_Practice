using System;

public class Lesson05
{
    public static void Main()
    {
        int[][][] letters = {
            new int[][] {
                new int[] {0, 0, 1, 1, 0, 0},
                new int[] {0, 1, 0, 0, 1, 0},
                new int[] {1, 0, 0, 0, 0, 1},
                new int[] {1, 1, 1, 1, 1, 1},
                new int[] {1, 0, 0, 0, 0, 1},
                new int[] {1, 0, 0, 0, 0, 1}
            },
            new int[][] {
                new int[] {1, 1, 1, 1, 1, 0},
                new int[] {1, 0, 0, 0, 0, 1},
                new int[] {1, 1, 1, 1, 1, 0},
                new int[] {1, 0, 0, 0, 0, 1},
                new int[] {1, 0, 0, 0, 0, 1},
                new int[] {1, 1, 1, 1, 1, 0}
            },
            new int[][] {
                new int[] {0, 1, 1, 1, 1, 0},
                new int[] {1, 0, 0, 0, 0, 1},
                new int[] {1, 0, 0, 0, 0, 0},
                new int[] {1, 0, 0, 0, 0, 0},
                new int[] {1, 0, 0, 0, 0, 1},
                new int[] {0, 1, 1, 1, 1, 0}
            }
        };

        // ここに、ドットを表示するコードを記述する
        
        foreach(int[][] letter in letters){
            foreach(int[] line in letter){
                foreach (int dot in line)
                {
                    if (dot == 1)
                    {
                        Console.Write("@");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        

        
    }
}
