using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x02000711 RID: 1809
	public class NewGameScreen : MainMenuScreen
	{
		// Token: 0x0600A122 RID: 41250 RVA: 0x0028D3B4 File Offset: 0x0028B5B4
		// Note: this type is marked as 'beforefieldinit'.
		static NewGameScreen()
		{
			Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "NewGameScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr);
			NewGameScreen.NativeFieldInfoPtr_ConfirmOverwriteScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr, "ConfirmOverwriteScreen");
			NewGameScreen.NativeFieldInfoPtr_SetupScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr, "SetupScreen");
			NewGameScreen.NativeMethodInfoPtr_SlotSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr, 100683160);
			NewGameScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr, 100683161);
		}

		// Token: 0x0600A123 RID: 41251 RVA: 0x0028D434 File Offset: 0x0028B634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284728, XrefRangeEnd = 284734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlotSelected(int slotIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slotIndex;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewGameScreen.NativeMethodInfoPtr_SlotSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A124 RID: 41252 RVA: 0x0028D474 File Offset: 0x0028B674
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewGameScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewGameScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A125 RID: 41253 RVA: 0x0004ED36 File Offset: 0x0004CF36
		public NewGameScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003169 RID: 12649
		// (get) Token: 0x0600A126 RID: 41254 RVA: 0x0028D4B0 File Offset: 0x0028B6B0
		// (set) Token: 0x0600A127 RID: 41255 RVA: 0x0004ED3F File Offset: 0x0004CF3F
		public unsafe ConfirmOverwriteScreen ConfirmOverwriteScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewGameScreen.NativeFieldInfoPtr_ConfirmOverwriteScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOverwriteScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewGameScreen.NativeFieldInfoPtr_ConfirmOverwriteScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700316A RID: 12650
		// (get) Token: 0x0600A128 RID: 41256 RVA: 0x0028D4E0 File Offset: 0x0028B6E0
		// (set) Token: 0x0600A129 RID: 41257 RVA: 0x0004ED5E File Offset: 0x0004CF5E
		public unsafe SetupScreen SetupScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewGameScreen.NativeFieldInfoPtr_SetupScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetupScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewGameScreen.NativeFieldInfoPtr_SetupScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006C27 RID: 27687
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmOverwriteScreen;

		// Token: 0x04006C28 RID: 27688
		private static readonly IntPtr NativeFieldInfoPtr_SetupScreen;

		// Token: 0x04006C29 RID: 27689
		private static readonly IntPtr NativeMethodInfoPtr_SlotSelected_Public_Void_Int32_0;

		// Token: 0x04006C2A RID: 27690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
