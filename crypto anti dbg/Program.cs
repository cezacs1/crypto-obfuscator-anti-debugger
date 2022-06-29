using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp3
{
	// Token: 0x02000004 RID: 4
	internal class ProjectType
	{
		// Token: 0x06000005 RID: 5
		[DllImport("kernel32.dll", EntryPoint = "SetLastError", ExactSpelling = true)]
		internal static extern void CopyBookmark(uint valuesID);

		// Token: 0x06000006 RID: 6
		[DllImport("kernel32.dll", EntryPoint = "CloseHandle", ExactSpelling = true)]
		internal static extern int EditPage(IntPtr valuesID);

		// Token: 0x06000007 RID: 7
		[DllImport("kernel32.dll", EntryPoint = "OpenProcess", ExactSpelling = true)]
		internal static extern IntPtr SaveProject(uint valuesID, int currentHandler, uint firstWindow);

		// Token: 0x06000008 RID: 8
		[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessId", ExactSpelling = true)]
		internal static extern uint CloseDeployment();

		// Token: 0x06000009 RID: 9
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "LoadLibrary", SetLastError = true)]
		internal static extern IntPtr HideToolbar(string valuesID);

		// Token: 0x0600000A RID: 10
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
		internal static extern ProjectType.AddinConverter ExitIcon(IntPtr valuesID, string currentHandler);

		// Token: 0x0600000B RID: 11
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
		internal static extern ProjectType.TextFileScope ChangeMenuItem(IntPtr valuesID, string currentHandler);

		// Token: 0x0600000C RID: 12
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
		internal static extern ProjectType.ActivatorConverter CleanBuilder(IntPtr valuesID, string currentHandler);

		// Token: 0x0600000D RID: 13
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
		internal static extern ProjectType.ControlCollection UncheckDevice(IntPtr valuesID, string currentHandler);

		// Token: 0x0600000E RID: 14
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
		internal static extern ProjectType.BuilderType CleanSolution(IntPtr valuesID, string currentHandler);

		// Token: 0x0600000F RID: 15
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
		internal static extern ProjectType.SymbolFactory ClosePciture(IntPtr valuesID, string currentHandler);


		public static void Main()
		{
			Console.WriteLine("hi! its crypto obfuscator's anti debugger");

			OrderVector(); //initalize anti debugger

			Console.ReadKey();
		}



		private static int CopySymbol(IntPtr valuesID, IntPtr currentHandler)
		{
			string[] array = new string[]
			{
				"OLLYDBG"
			};
			string strA = ProjectType.UpdateVector(valuesID);
			foreach (string strB in array)
			{
				if (string.Compare(strA, strB, true) == 0)
				{
					ProjectType.fontAvailable = true;
					return 0;
				}
			}
			return 1;
		}

		// Token: 0x06000011 RID: 17
		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetClassName")]
		internal static extern int ChangeTextFile(IntPtr valuesID, StringBuilder currentHandler, int firstWindow);

		// Token: 0x06000012 RID: 18 RVA: 0x0000210C File Offset: 0x0000030C
		internal static string UpdateVector(IntPtr valuesID)
		{
			StringBuilder stringBuilder = new StringBuilder(260);
			ProjectType.ChangeTextFile(valuesID, stringBuilder, stringBuilder.Capacity);
			return stringBuilder.ToString();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002138 File Offset: 0x00000338
		internal static void OrderVector()
		{
			if (ProjectType.DisposeForm())
			{
				string arg = "Debugger";
				throw new Exception(string.Format("{0}{1} was found - this software cannot be executed under the {0}.", arg, ""));
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002168 File Offset: 0x00000368
		internal static bool DisposeForm()
		{
			try
			{
				if (Debugger.IsAttached)
				{
					return true;
				}
				IntPtr intPtr = ProjectType.HideToolbar("kernel32.dll");
				ProjectType.ControlCollection controlCollection = ProjectType.UncheckDevice(intPtr, "IsDebuggerPresent");
				if (controlCollection != null && controlCollection() != 0)
				{
					return true;
				}
				uint num = ProjectType.CloseDeployment();
				IntPtr intPtr2 = ProjectType.SaveProject(1024U, 0, num);
				if (intPtr2 != IntPtr.Zero)
				{
					try
					{
						ProjectType.ActivatorConverter activatorConverter = ProjectType.CleanBuilder(intPtr, "CheckRemoteDebuggerPresent");
						if (activatorConverter != null)
						{
							int num2 = 0;
							if (activatorConverter(intPtr2, ref num2) != 0 && num2 != 0)
							{
								return true;
							}
						}
					}
					finally
					{
						ProjectType.EditPage(intPtr2);
					}
				}
				bool flag = false;
				try
				{
					ProjectType.EditPage(new IntPtr(305419896));
				}
				catch
				{
					flag = true;
				}
				if (flag)
				{
					return true;
				}
				try
				{
					IntPtr intPtr3 = ProjectType.HideToolbar("user32.dll");
					ProjectType.SymbolFactory symbolFactory = ProjectType.ClosePciture(intPtr3, "EnumWindows");
					if (symbolFactory != null)
					{
						ProjectType.fontAvailable = false;
						symbolFactory(new ProjectType.EditorSet(ProjectType.CopySymbol), IntPtr.Zero);
						if (ProjectType.fontAvailable)
						{
							return true;
						}
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x04000001 RID: 1
		internal const uint valuesID = 1024U;

		// Token: 0x04000002 RID: 2
		internal const uint currentHandler = 64U;

		// Token: 0x04000003 RID: 3
		internal const int firstWindow = 0;

		// Token: 0x04000004 RID: 4
		private static bool fontAvailable;

		// Token: 0x02000005 RID: 5
		[StructLayout(LayoutKind.Sequential)]
		internal class BitmapScope
		{
			// Token: 0x04000005 RID: 5
			internal IntPtr valuesID;

			// Token: 0x04000006 RID: 6
			internal IntPtr currentHandler;

			// Token: 0x04000007 RID: 7
			internal IntPtr firstWindow;

			// Token: 0x04000008 RID: 8
			internal IntPtr fontAvailable;

			// Token: 0x04000009 RID: 9
			internal IntPtr parentCaption;

			// Token: 0x0400000A RID: 10
			internal IntPtr lockInitialized;
		}

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000017 RID: 23
		internal delegate int AddinConverter(IntPtr ProcessHandle, int ProcessInformationClass, ProjectType.BitmapScope ProcessInformation, uint ProcessInformationLength, out uint ReturnLength);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x0600001B RID: 27
		internal delegate int TextFileScope(IntPtr ProcessHandle, int ProcessInformationClass, out uint debugPort, uint ProcessInformationLength, out uint ReturnLength);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x0600001F RID: 31
		internal delegate int ControlCollection();

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000023 RID: 35
		internal delegate void BuilderType([MarshalAs(UnmanagedType.LPStr)] string lpOutputString);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000027 RID: 39
		internal delegate int ActivatorConverter(IntPtr hProcess, ref int pbDebuggerPresent);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x0600002B RID: 43
		internal delegate int EditorSet(IntPtr wnd, IntPtr lParam);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x0600002F RID: 47
		internal delegate int SymbolFactory(ProjectType.EditorSet lpEnumFunc, IntPtr lParam);
	}
}
