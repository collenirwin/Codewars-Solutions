using System;
using System.Linq;

public static partial class Kata
{
  public static string GetNote(double pitch)
  {
    return NotesDictionary.ContainsKey(pitch)
      ? NotesDictionary[pitch] 
      : NotesDictionary[NotesDictionary.Keys
        .First(x => pitch > x ? pitch % x == 0 : x % pitch == 0)];
  }
}