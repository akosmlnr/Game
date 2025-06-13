using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x02000701 RID: 1793
	public class DryingRackUIElement : WorldspaceUIElement
	{
		// Token: 0x0600A04B RID: 41035 RVA: 0x0028A9CC File Offset: 0x00288BCC
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackUIElement()
		{
			Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "DryingRackUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr);
			DryingRackUIElement.NativeFieldInfoPtr__AssignedRack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, "<AssignedRack>k__BackingField");
			DryingRackUIElement.NativeFieldInfoPtr_TargetQualityIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, "TargetQualityIcon");
			DryingRackUIElement.NativeMethodInfoPtr_get_AssignedRack_Public_get_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100683055);
			DryingRackUIElement.NativeMethodInfoPtr_set_AssignedRack_Protected_set_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100683056);
			DryingRackUIElement.NativeMethodInfoPtr_Initialize_Public_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100683057);
			DryingRackUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100683058);
			DryingRackUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100683059);
		}

		// Token: 0x1700312E RID: 12590
		// (get) Token: 0x0600A04C RID: 41036 RVA: 0x0028AA88 File Offset: 0x00288C88
		// (set) Token: 0x0600A04D RID: 41037 RVA: 0x0028AAC8 File Offset: 0x00288CC8
		public unsafe DryingRack AssignedRack
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17870, RefRangeEnd = 17871, XrefRangeStart = 17870, XrefRangeEnd = 17871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackUIElement.NativeMethodInfoPtr_get_AssignedRack_Public_get_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 40500, RefRangeEnd = 40502, XrefRangeStart = 40500, XrefRangeEnd = 40502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackUIElement.NativeMethodInfoPtr_set_AssignedRack_Protected_set_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A04E RID: 41038 RVA: 0x0028AB0C File Offset: 0x00288D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284061, RefRangeEnd = 284062, XrefRangeStart = 284051, XrefRangeEnd = 284061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(DryingRack rack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rack);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackUIElement.NativeMethodInfoPtr_Initialize_Public_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A04F RID: 41039 RVA: 0x0028AB50 File Offset: 0x00288D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284062, XrefRangeEnd = 284071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A050 RID: 41040 RVA: 0x0028AB8C File Offset: 0x00288D8C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A051 RID: 41041 RVA: 0x0004E6BA File Offset: 0x0004C8BA
		public DryingRackUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700312C RID: 12588
		// (get) Token: 0x0600A052 RID: 41042 RVA: 0x0028ABC8 File Offset: 0x00288DC8
		// (set) Token: 0x0600A053 RID: 41043 RVA: 0x0004E6C3 File Offset: 0x0004C8C3
		public unsafe DryingRack _AssignedRack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackUIElement.NativeFieldInfoPtr__AssignedRack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackUIElement.NativeFieldInfoPtr__AssignedRack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700312D RID: 12589
		// (get) Token: 0x0600A054 RID: 41044 RVA: 0x0028ABF8 File Offset: 0x00288DF8
		// (set) Token: 0x0600A055 RID: 41045 RVA: 0x0004E6E2 File Offset: 0x0004C8E2
		public unsafe Image TargetQualityIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackUIElement.NativeFieldInfoPtr_TargetQualityIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackUIElement.NativeFieldInfoPtr_TargetQualityIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BA4 RID: 27556
		private static readonly IntPtr NativeFieldInfoPtr__AssignedRack_k__BackingField;

		// Token: 0x04006BA5 RID: 27557
		private static readonly IntPtr NativeFieldInfoPtr_TargetQualityIcon;

		// Token: 0x04006BA6 RID: 27558
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedRack_Public_get_DryingRack_0;

		// Token: 0x04006BA7 RID: 27559
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedRack_Protected_set_Void_DryingRack_0;

		// Token: 0x04006BA8 RID: 27560
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_DryingRack_0;

		// Token: 0x04006BA9 RID: 27561
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006BAA RID: 27562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
