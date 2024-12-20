// using System;
// namespace facade
// {
//  /// <summary>
//  /// Facade Design Pattern
//  /// </summary>
//  public class Program
//  {
//  public static void Main(string[] args)
//  {
//  Facade facade = new Facade();
//  facade.MethodA();
//  facade.MethodB();
//  // Wait for user
//  Console.ReadKey();
//  }
// }
//  /// <summary>
//  /// The 'Subsystem ClassA' class
//  /// </summary>
//  public class SubSystemOne
//  {
//  public void MethodOne()
//  {
//  Console.WriteLine(" SubSystemOne Method");
//  }
//  }
//  /// <summary>
//  /// The 'Subsystem ClassB' class
//  /// </summary>
//  public class SubSystemTwo
//  {
//  public void MethodTwo()
//  {
//  Console.WriteLine(" SubSystemTwo Method");
//  }
//  }
//  /// <summary>
//  /// The 'Subsystem ClassC' class
//  /// </summary>
//  public class SubSystemThree
//  {
//  public void MethodThree()
//  {
//  Console.WriteLine(" SubSystemThree Method");
//  }
//  }
//  /// <summary>
//  /// The 'Subsystem ClassD' class
//  /// </summary>
//  public class SubSystemFour
//  {
//  public void MethodFour()
//  {
//  Console.WriteLine(" SubSystemFour Method");
//  }
//  }
// /// The 'Facade' class
//  public class Facade
//  {
//  SubSystemOne one;
//  SubSystemTwo two;
//  SubSystemThree three;
//  SubSystemFour four;
//  public Facade()
//  {
//  one = new SubSystemOne();
//  two = new SubSystemTwo();
//  three = new SubSystemThree();
//  four = new SubSystemFour();
//  }
//  public void MethodA()
//  {
//  Console.WriteLine("\nMethodA() ---- ");
//  one.MethodOne();
//  two.MethodTwo();
//  four.MethodFour();
//  }
//  public void MethodB()
//  {
//  Console.WriteLine("\nMethodB() ---- ");
//  two.MethodTwo();
//  three.MethodThree();
//  }
//  }
// }
using System;
namespace facade
{
 /// <summary>
 /// Facade Design Pattern
 /// </summary>
 public class Program
 {
 public static void Main(string[] args)
 {
 Computer facade = new Computer();
 facade.Boot();
 facade.Shutdown();
 // Wait for user
 Console.ReadKey();
 }
}
 /// <summary>
 /// The 'Subsystem ClassA' class
 /// </summary>
 public class SubSystemOne
 {
 public void CPUStart()
 {
 Console.WriteLine(" SubSystemOne CPU Starting");
 }
 public void CPUStop()
 {
 Console.WriteLine(" SubSystemOne CPU stopped");
 }
 }
 /// <summary>
 /// The 'Subsystem ClassB' class
 /// </summary>
 public class SubSystemTwo
 {
 public void HarddiskStart()
 {
 Console.WriteLine(" SubSystemTwo Harddisk started");
 }
 public void HarddiskStop()
 {
 Console.WriteLine(" SubSystemTwo Harddisk stoped");
 }
 }
 /// <summary>
 /// The 'Subsystem ClassC' class
 /// </summary>
 public class SubSystemThree
 {
 public void SSDStart()
 {
 Console.WriteLine(" SubSystemThree SSD Started");
 }
 public void SSDStop()
 {
 Console.WriteLine(" SubSystemThree SSD Stoppped");
 }
 }
 /// <summary>
 /// The 'Subsystem ClassD' class
 /// </summary>
 public class SubSystemFour
 {
 public void RAMload()
 {
 Console.WriteLine(" SubSystemFour RAM loaded");
 }
 public void RAMfree()
 {
 Console.WriteLine(" SubSystemFour RAM free");
 }
 }
/// The 'Facade' class
 public class Computer
 {
 SubSystemOne cpu;
 SubSystemTwo harddisk;
 SubSystemThree ssd;
 SubSystemFour ram;
 public Computer()
 {
 cpu = new SubSystemOne();
 harddisk = new SubSystemTwo();
 ssd = new SubSystemThree();
 ram = new SubSystemFour();
 }
 public void Boot()
 {
 Console.WriteLine("\nBoot() ---- ");
 cpu.CPUStart();
 harddisk.HarddiskStart();
 ram.RAMload();
 ssd.SSDStart();
 }
 public void Shutdown()
 {
 Console.WriteLine("\nShutdown() ---- ");
 cpu.CPUStop();
 harddisk.HarddiskStop();
 ram.RAMfree();
 ssd.SSDStop();
 }
 }
}
