using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.UI.Stations;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006FE RID: 1790
	public class ChemistryStationUIElement : WorldspaceUIElement
	{
		// Token: 0x0600A028 RID: 41000 RVA: 0x0028A274 File Offset: 0x00288474
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationUIElement()
		{
			Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ChemistryStationUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr);
			ChemistryStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, "<AssignedStation>k__BackingField");
			ChemistryStationUIElement.NativeFieldInfoPtr_RecipeEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, "RecipeEntry");
			ChemistryStationUIElement.NativeFieldInfoPtr_NoRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, "NoRecipe");
			ChemistryStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100683040);
			ChemistryStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100683041);
			ChemistryStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100683042);
			ChemistryStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100683043);
			ChemistryStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr, 100683044);
		}

		// Token: 0x17003125 RID: 12581
		// (get) Token: 0x0600A029 RID: 41001 RVA: 0x0028A344 File Offset: 0x00288544
		// (set) Token: 0x0600A02A RID: 41002 RVA: 0x0028A384 File Offset: 0x00288584
		public unsafe ChemistryStation AssignedStation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17870, RefRangeEnd = 17871, XrefRangeStart = 17870, XrefRangeEnd = 17871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 40500, RefRangeEnd = 40502, XrefRangeStart = 40500, XrefRangeEnd = 40502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A02B RID: 41003 RVA: 0x0028A3C8 File Offset: 0x002885C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283986, RefRangeEnd = 283987, XrefRangeStart = 283976, XrefRangeEnd = 283986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ChemistryStation oven)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A02C RID: 41004 RVA: 0x0028A40C File Offset: 0x0028860C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283987, XrefRangeEnd = 284003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A02D RID: 41005 RVA: 0x0028A448 File Offset: 0x00288648
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationUIElement>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A02E RID: 41006 RVA: 0x0004E5C6 File Offset: 0x0004C7C6
		public ChemistryStationUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003122 RID: 12578
		// (get) Token: 0x0600A02F RID: 41007 RVA: 0x0028A484 File Offset: 0x00288684
		// (set) Token: 0x0600A030 RID: 41008 RVA: 0x0004E5CF File Offset: 0x0004C7CF
		public unsafe ChemistryStation _AssignedStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003123 RID: 12579
		// (get) Token: 0x0600A031 RID: 41009 RVA: 0x0028A4B4 File Offset: 0x002886B4
		// (set) Token: 0x0600A032 RID: 41010 RVA: 0x0004E5EE File Offset: 0x0004C7EE
		public unsafe StationRecipeEntry RecipeEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr_RecipeEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr_RecipeEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003124 RID: 12580
		// (get) Token: 0x0600A033 RID: 41011 RVA: 0x0028A4E4 File Offset: 0x002886E4
		// (set) Token: 0x0600A034 RID: 41012 RVA: 0x0004E60D File Offset: 0x0004C80D
		public unsafe GameObject NoRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr_NoRecipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationUIElement.NativeFieldInfoPtr_NoRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006B8E RID: 27534
		private static readonly IntPtr NativeFieldInfoPtr__AssignedStation_k__BackingField;

		// Token: 0x04006B8F RID: 27535
		private static readonly IntPtr NativeFieldInfoPtr_RecipeEntry;

		// Token: 0x04006B90 RID: 27536
		private static readonly IntPtr NativeFieldInfoPtr_NoRecipe;

		// Token: 0x04006B91 RID: 27537
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedStation_Public_get_ChemistryStation_0;

		// Token: 0x04006B92 RID: 27538
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_ChemistryStation_0;

		// Token: 0x04006B93 RID: 27539
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ChemistryStation_0;

		// Token: 0x04006B94 RID: 27540
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006B95 RID: 27541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
