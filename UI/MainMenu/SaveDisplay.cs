using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x02000712 RID: 1810
	public class SaveDisplay : MonoBehaviour
	{
		// Token: 0x0600A12A RID: 41258 RVA: 0x0028D510 File Offset: 0x0028B710
		// Note: this type is marked as 'beforefieldinit'.
		static SaveDisplay()
		{
			Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "SaveDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr);
			SaveDisplay.NativeFieldInfoPtr_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, "Slots");
			SaveDisplay.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100683162);
			SaveDisplay.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100683163);
			SaveDisplay.NativeMethodInfoPtr_SetDisplayedSave_Public_Void_Int32_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100683164);
			SaveDisplay.NativeMethodInfoPtr_RoundToDecimalPlaces_Private_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100683165);
			SaveDisplay.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100683166);
			SaveDisplay.NativeMethodInfoPtr_GetTimeLabel_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100683167);
			SaveDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100683168);
		}

		// Token: 0x0600A12B RID: 41259 RVA: 0x0028D5E0 File Offset: 0x0028B7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284734, XrefRangeEnd = 284753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A12C RID: 41260 RVA: 0x0028D614 File Offset: 0x0028B814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284753, XrefRangeEnd = 284761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A12D RID: 41261 RVA: 0x0028D648 File Offset: 0x0028B848
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284835, RefRangeEnd = 284837, XrefRangeStart = 284761, XrefRangeEnd = 284835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedSave(int index, SaveInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_SetDisplayedSave_Public_Void_Int32_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A12E RID: 41262 RVA: 0x0028D698 File Offset: 0x0028B898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284843, RefRangeEnd = 284845, XrefRangeStart = 284837, XrefRangeEnd = 284843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RoundToDecimalPlaces(float value, int decimalPlaces)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decimalPlaces;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_RoundToDecimalPlaces_Private_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A12F RID: 41263 RVA: 0x0028D6F0 File Offset: 0x0028B8F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284845, RefRangeEnd = 284847, XrefRangeStart = 284845, XrefRangeEnd = 284845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(double value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A130 RID: 41264 RVA: 0x0028D730 File Offset: 0x0028B930
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284854, RefRangeEnd = 284856, XrefRangeStart = 284847, XrefRangeEnd = 284854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTimeLabel(int hours)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hours;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_GetTimeLabel_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600A131 RID: 41265 RVA: 0x0028D774 File Offset: 0x0028B974
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A132 RID: 41266 RVA: 0x0004ED7D File Offset: 0x0004CF7D
		public SaveDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700316B RID: 12651
		// (get) Token: 0x0600A133 RID: 41267 RVA: 0x0028D7B0 File Offset: 0x0028B9B0
		// (set) Token: 0x0600A134 RID: 41268 RVA: 0x0004ED86 File Offset: 0x0004CF86
		public unsafe Il2CppReferenceArray<RectTransform> Slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveDisplay.NativeFieldInfoPtr_Slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveDisplay.NativeFieldInfoPtr_Slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006C2B RID: 27691
		private static readonly IntPtr NativeFieldInfoPtr_Slots;

		// Token: 0x04006C2C RID: 27692
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04006C2D RID: 27693
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x04006C2E RID: 27694
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedSave_Public_Void_Int32_SaveInfo_0;

		// Token: 0x04006C2F RID: 27695
		private static readonly IntPtr NativeMethodInfoPtr_RoundToDecimalPlaces_Private_Single_Single_Int32_0;

		// Token: 0x04006C30 RID: 27696
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0;

		// Token: 0x04006C31 RID: 27697
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeLabel_Private_String_Int32_0;

		// Token: 0x04006C32 RID: 27698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
