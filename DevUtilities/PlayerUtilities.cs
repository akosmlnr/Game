using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000489 RID: 1161
	public static class PlayerUtilities : Il2CppSystem.Object
	{
		// Token: 0x060063A7 RID: 25511 RVA: 0x001C7DEC File Offset: 0x001C5FEC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerUtilities()
		{
			Il2CppClassPointerStore<PlayerUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PlayerUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerUtilities>.NativeClassPtr);
			PlayerUtilities.NativeMethodInfoPtr_OpenMenu_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerUtilities>.NativeClassPtr, 100676050);
			PlayerUtilities.NativeMethodInfoPtr_CloseMenu_Public_Static_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerUtilities>.NativeClassPtr, 100676051);
		}

		// Token: 0x060063A8 RID: 25512 RVA: 0x001C7E44 File Offset: 0x001C6044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205803, XrefRangeEnd = 205827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenMenu()
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerUtilities.NativeMethodInfoPtr_OpenMenu_Public_Static_Void_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063A9 RID: 25513 RVA: 0x001C7E6C File Offset: 0x001C606C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205827, XrefRangeEnd = 205851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CloseMenu(bool reenableLookInstantly = false, bool reenableInventory = true)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref reenableLookInstantly;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref reenableInventory;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerUtilities.NativeMethodInfoPtr_CloseMenu_Public_Static_Void_Boolean_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063AA RID: 25514 RVA: 0x0002EDD2 File Offset: 0x0002CFD2
		public PlayerUtilities(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040043FC RID: 17404
		private static readonly System.IntPtr NativeMethodInfoPtr_OpenMenu_Public_Static_Void_0;

		// Token: 0x040043FD RID: 17405
		private static readonly System.IntPtr NativeMethodInfoPtr_CloseMenu_Public_Static_Void_Boolean_Boolean_0;
	}
}
