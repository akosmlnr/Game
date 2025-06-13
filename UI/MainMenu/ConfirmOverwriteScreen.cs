using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x02000709 RID: 1801
	public class ConfirmOverwriteScreen : MainMenuScreen
	{
		// Token: 0x0600A0B3 RID: 41139 RVA: 0x0028BFD4 File Offset: 0x0028A1D4
		// Note: this type is marked as 'beforefieldinit'.
		static ConfirmOverwriteScreen()
		{
			Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "ConfirmOverwriteScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr);
			ConfirmOverwriteScreen.NativeFieldInfoPtr_SetupScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, "SetupScreen");
			ConfirmOverwriteScreen.NativeFieldInfoPtr_slotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, "slotIndex");
			ConfirmOverwriteScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, 100683112);
			ConfirmOverwriteScreen.NativeMethodInfoPtr_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, 100683113);
			ConfirmOverwriteScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, 100683114);
		}

		// Token: 0x0600A0B4 RID: 41140 RVA: 0x0028C068 File Offset: 0x0028A268
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 51093, RefRangeEnd = 51096, XrefRangeStart = 51093, XrefRangeEnd = 51096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOverwriteScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0B5 RID: 41141 RVA: 0x0028C0A8 File Offset: 0x0028A2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284362, XrefRangeEnd = 284363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOverwriteScreen.NativeMethodInfoPtr_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0B6 RID: 41142 RVA: 0x0028C0DC File Offset: 0x0028A2DC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmOverwriteScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOverwriteScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0B7 RID: 41143 RVA: 0x0004E978 File Offset: 0x0004CB78
		public ConfirmOverwriteScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003149 RID: 12617
		// (get) Token: 0x0600A0B8 RID: 41144 RVA: 0x0028C118 File Offset: 0x0028A318
		// (set) Token: 0x0600A0B9 RID: 41145 RVA: 0x0004E981 File Offset: 0x0004CB81
		public unsafe SetupScreen SetupScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOverwriteScreen.NativeFieldInfoPtr_SetupScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetupScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOverwriteScreen.NativeFieldInfoPtr_SetupScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700314A RID: 12618
		// (get) Token: 0x0600A0BA RID: 41146 RVA: 0x0028C148 File Offset: 0x0028A348
		// (set) Token: 0x0600A0BB RID: 41147 RVA: 0x0004E9A0 File Offset: 0x0004CBA0
		public unsafe int slotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOverwriteScreen.NativeFieldInfoPtr_slotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOverwriteScreen.NativeFieldInfoPtr_slotIndex)) = value;
			}
		}

		// Token: 0x04006BE7 RID: 27623
		private static readonly IntPtr NativeFieldInfoPtr_SetupScreen;

		// Token: 0x04006BE8 RID: 27624
		private static readonly IntPtr NativeFieldInfoPtr_slotIndex;

		// Token: 0x04006BE9 RID: 27625
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_0;

		// Token: 0x04006BEA RID: 27626
		private static readonly IntPtr NativeMethodInfoPtr_Confirm_Public_Void_0;

		// Token: 0x04006BEB RID: 27627
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
