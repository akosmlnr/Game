using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x0200070A RID: 1802
	public class ContinueScreen : MainMenuScreen
	{
		// Token: 0x0600A0BC RID: 41148 RVA: 0x0028C170 File Offset: 0x0028A370
		// Note: this type is marked as 'beforefieldinit'.
		static ContinueScreen()
		{
			Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "ContinueScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr);
			ContinueScreen.NativeFieldInfoPtr_NotHostWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr, "NotHostWarning");
			ContinueScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr, 100683115);
			ContinueScreen.NativeMethodInfoPtr_LoadGame_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr, 100683116);
			ContinueScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr, 100683117);
		}

		// Token: 0x0600A0BD RID: 41149 RVA: 0x0028C1F0 File Offset: 0x0028A3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284363, XrefRangeEnd = 284370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0BE RID: 41150 RVA: 0x0028C224 File Offset: 0x0028A424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284370, XrefRangeEnd = 284392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadGame(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueScreen.NativeMethodInfoPtr_LoadGame_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0BF RID: 41151 RVA: 0x0028C264 File Offset: 0x0028A464
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContinueScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0C0 RID: 41152 RVA: 0x0004E9BB File Offset: 0x0004CBBB
		public ContinueScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700314B RID: 12619
		// (get) Token: 0x0600A0C1 RID: 41153 RVA: 0x0028C2A0 File Offset: 0x0028A4A0
		// (set) Token: 0x0600A0C2 RID: 41154 RVA: 0x0004E9C4 File Offset: 0x0004CBC4
		public unsafe RectTransform NotHostWarning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueScreen.NativeFieldInfoPtr_NotHostWarning);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueScreen.NativeFieldInfoPtr_NotHostWarning), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BEC RID: 27628
		private static readonly IntPtr NativeFieldInfoPtr_NotHostWarning;

		// Token: 0x04006BED RID: 27629
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006BEE RID: 27630
		private static readonly IntPtr NativeMethodInfoPtr_LoadGame_Public_Void_Int32_0;

		// Token: 0x04006BEF RID: 27631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
