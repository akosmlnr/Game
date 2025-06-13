using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x02000704 RID: 1796
	public class PackagerUIElement : WorldspaceUIElement
	{
		// Token: 0x0600A068 RID: 41064 RVA: 0x0028B058 File Offset: 0x00289258
		// Note: this type is marked as 'beforefieldinit'.
		static PackagerUIElement()
		{
			Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PackagerUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr);
			PackagerUIElement.NativeFieldInfoPtr_StationRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, "StationRects");
			PackagerUIElement.NativeFieldInfoPtr__AssignedPackager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, "<AssignedPackager>k__BackingField");
			PackagerUIElement.NativeMethodInfoPtr_get_AssignedPackager_Public_get_Packager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100683070);
			PackagerUIElement.NativeMethodInfoPtr_set_AssignedPackager_Protected_set_Void_Packager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100683071);
			PackagerUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Packager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100683072);
			PackagerUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100683073);
			PackagerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100683074);
		}

		// Token: 0x17003135 RID: 12597
		// (get) Token: 0x0600A069 RID: 41065 RVA: 0x0028B114 File Offset: 0x00289314
		// (set) Token: 0x0600A06A RID: 41066 RVA: 0x0028B154 File Offset: 0x00289354
		public unsafe Packager AssignedPackager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerUIElement.NativeMethodInfoPtr_get_AssignedPackager_Public_get_Packager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Packager>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerUIElement.NativeMethodInfoPtr_set_AssignedPackager_Protected_set_Void_Packager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A06B RID: 41067 RVA: 0x0028B198 File Offset: 0x00289398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284114, RefRangeEnd = 284115, XrefRangeStart = 284103, XrefRangeEnd = 284114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Packager packager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(packager);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Packager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A06C RID: 41068 RVA: 0x0028B1DC File Offset: 0x002893DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284115, XrefRangeEnd = 284139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagerUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A06D RID: 41069 RVA: 0x0028B218 File Offset: 0x00289418
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagerUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A06E RID: 41070 RVA: 0x0004E751 File Offset: 0x0004C951
		public PackagerUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003133 RID: 12595
		// (get) Token: 0x0600A06F RID: 41071 RVA: 0x0028B254 File Offset: 0x00289454
		// (set) Token: 0x0600A070 RID: 41072 RVA: 0x0004E75A File Offset: 0x0004C95A
		public unsafe Il2CppReferenceArray<RectTransform> StationRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerUIElement.NativeFieldInfoPtr_StationRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerUIElement.NativeFieldInfoPtr_StationRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003134 RID: 12596
		// (get) Token: 0x0600A071 RID: 41073 RVA: 0x0028B284 File Offset: 0x00289484
		// (set) Token: 0x0600A072 RID: 41074 RVA: 0x0004E779 File Offset: 0x0004C979
		public unsafe Packager _AssignedPackager_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerUIElement.NativeFieldInfoPtr__AssignedPackager_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Packager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerUIElement.NativeFieldInfoPtr__AssignedPackager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BB7 RID: 27575
		private static readonly IntPtr NativeFieldInfoPtr_StationRects;

		// Token: 0x04006BB8 RID: 27576
		private static readonly IntPtr NativeFieldInfoPtr__AssignedPackager_k__BackingField;

		// Token: 0x04006BB9 RID: 27577
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedPackager_Public_get_Packager_0;

		// Token: 0x04006BBA RID: 27578
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedPackager_Protected_set_Void_Packager_0;

		// Token: 0x04006BBB RID: 27579
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Packager_0;

		// Token: 0x04006BBC RID: 27580
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006BBD RID: 27581
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
