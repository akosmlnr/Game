using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006FF RID: 1791
	public class ChemistUIElement : WorldspaceUIElement
	{
		// Token: 0x0600A035 RID: 41013 RVA: 0x0028A514 File Offset: 0x00288714
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistUIElement()
		{
			Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ChemistUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr);
			ChemistUIElement.NativeFieldInfoPtr_StationsIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, "StationsIcons");
			ChemistUIElement.NativeFieldInfoPtr__AssignedChemist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, "<AssignedChemist>k__BackingField");
			ChemistUIElement.NativeMethodInfoPtr_get_AssignedChemist_Public_get_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100683045);
			ChemistUIElement.NativeMethodInfoPtr_set_AssignedChemist_Protected_set_Void_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100683046);
			ChemistUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100683047);
			ChemistUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100683048);
			ChemistUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100683049);
		}

		// Token: 0x17003128 RID: 12584
		// (get) Token: 0x0600A036 RID: 41014 RVA: 0x0028A5D0 File Offset: 0x002887D0
		// (set) Token: 0x0600A037 RID: 41015 RVA: 0x0028A610 File Offset: 0x00288810
		public unsafe Chemist AssignedChemist
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistUIElement.NativeMethodInfoPtr_get_AssignedChemist_Public_get_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistUIElement.NativeMethodInfoPtr_set_AssignedChemist_Protected_set_Void_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A038 RID: 41016 RVA: 0x0028A654 File Offset: 0x00288854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284014, RefRangeEnd = 284015, XrefRangeStart = 284003, XrefRangeEnd = 284014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Chemist chemist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(chemist);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A039 RID: 41017 RVA: 0x0028A698 File Offset: 0x00288898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284015, XrefRangeEnd = 284027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A03A RID: 41018 RVA: 0x0028A6D4 File Offset: 0x002888D4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A03B RID: 41019 RVA: 0x0004E62C File Offset: 0x0004C82C
		public ChemistUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003126 RID: 12582
		// (get) Token: 0x0600A03C RID: 41020 RVA: 0x0028A710 File Offset: 0x00288910
		// (set) Token: 0x0600A03D RID: 41021 RVA: 0x0004E635 File Offset: 0x0004C835
		public unsafe Il2CppReferenceArray<Image> StationsIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistUIElement.NativeFieldInfoPtr_StationsIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistUIElement.NativeFieldInfoPtr_StationsIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003127 RID: 12583
		// (get) Token: 0x0600A03E RID: 41022 RVA: 0x0028A740 File Offset: 0x00288940
		// (set) Token: 0x0600A03F RID: 41023 RVA: 0x0004E654 File Offset: 0x0004C854
		public unsafe Chemist _AssignedChemist_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistUIElement.NativeFieldInfoPtr__AssignedChemist_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistUIElement.NativeFieldInfoPtr__AssignedChemist_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006B96 RID: 27542
		private static readonly IntPtr NativeFieldInfoPtr_StationsIcons;

		// Token: 0x04006B97 RID: 27543
		private static readonly IntPtr NativeFieldInfoPtr__AssignedChemist_k__BackingField;

		// Token: 0x04006B98 RID: 27544
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedChemist_Public_get_Chemist_0;

		// Token: 0x04006B99 RID: 27545
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedChemist_Protected_set_Void_Chemist_0;

		// Token: 0x04006B9A RID: 27546
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Chemist_0;

		// Token: 0x04006B9B RID: 27547
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006B9C RID: 27548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
