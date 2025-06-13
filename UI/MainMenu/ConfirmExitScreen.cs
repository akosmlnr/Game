using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x02000708 RID: 1800
	public class ConfirmExitScreen : MainMenuScreen
	{
		// Token: 0x0600A0AC RID: 41132 RVA: 0x0028BE80 File Offset: 0x0028A080
		// Note: this type is marked as 'beforefieldinit'.
		static ConfirmExitScreen()
		{
			Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "ConfirmExitScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr);
			ConfirmExitScreen.NativeFieldInfoPtr_TimeSinceSaveLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr, "TimeSinceSaveLabel");
			ConfirmExitScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr, 100683109);
			ConfirmExitScreen.NativeMethodInfoPtr_ConfirmExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr, 100683110);
			ConfirmExitScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr, 100683111);
		}

		// Token: 0x0600A0AD RID: 41133 RVA: 0x0028BF00 File Offset: 0x0028A100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284343, XrefRangeEnd = 284356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmExitScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0AE RID: 41134 RVA: 0x0028BF34 File Offset: 0x0028A134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284356, XrefRangeEnd = 284362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmExitScreen.NativeMethodInfoPtr_ConfirmExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0AF RID: 41135 RVA: 0x0028BF68 File Offset: 0x0028A168
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmExitScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmExitScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0B0 RID: 41136 RVA: 0x0004E950 File Offset: 0x0004CB50
		public ConfirmExitScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003148 RID: 12616
		// (get) Token: 0x0600A0B1 RID: 41137 RVA: 0x0028BFA4 File Offset: 0x0028A1A4
		// (set) Token: 0x0600A0B2 RID: 41138 RVA: 0x0004E959 File Offset: 0x0004CB59
		public unsafe TextMeshProUGUI TimeSinceSaveLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmExitScreen.NativeFieldInfoPtr_TimeSinceSaveLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmExitScreen.NativeFieldInfoPtr_TimeSinceSaveLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BE3 RID: 27619
		private static readonly IntPtr NativeFieldInfoPtr_TimeSinceSaveLabel;

		// Token: 0x04006BE4 RID: 27620
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006BE5 RID: 27621
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmExit_Public_Void_0;

		// Token: 0x04006BE6 RID: 27622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
