using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000494 RID: 1172
	[System.Serializable]
	public class GameSettings : Il2CppSystem.Object
	{
		// Token: 0x0600644D RID: 25677 RVA: 0x001C9DE8 File Offset: 0x001C7FE8
		// Note: this type is marked as 'beforefieldinit'.
		static GameSettings()
		{
			Il2CppClassPointerStore<GameSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "GameSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSettings>.NativeClassPtr);
			GameSettings.NativeFieldInfoPtr_ConsoleEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "ConsoleEnabled");
			GameSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, 100676114);
		}

		// Token: 0x0600644E RID: 25678 RVA: 0x001C9E40 File Offset: 0x001C8040
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameSettings>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600644F RID: 25679 RVA: 0x0002F2CB File Offset: 0x0002D4CB
		public GameSettings(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x06006450 RID: 25680 RVA: 0x001C9E7C File Offset: 0x001C807C
		// (set) Token: 0x06006451 RID: 25681 RVA: 0x0002F2D4 File Offset: 0x0002D4D4
		public unsafe bool ConsoleEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettings.NativeFieldInfoPtr_ConsoleEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettings.NativeFieldInfoPtr_ConsoleEnabled)) = value;
			}
		}

		// Token: 0x0400446F RID: 17519
		private static readonly System.IntPtr NativeFieldInfoPtr_ConsoleEnabled;

		// Token: 0x04004470 RID: 17520
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
