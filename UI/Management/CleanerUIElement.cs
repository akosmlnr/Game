using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x02000700 RID: 1792
	public class CleanerUIElement : WorldspaceUIElement
	{
		// Token: 0x0600A040 RID: 41024 RVA: 0x0028A770 File Offset: 0x00288970
		// Note: this type is marked as 'beforefieldinit'.
		static CleanerUIElement()
		{
			Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "CleanerUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr);
			CleanerUIElement.NativeFieldInfoPtr_StationsIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, "StationsIcons");
			CleanerUIElement.NativeFieldInfoPtr__AssignedCleaner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, "<AssignedCleaner>k__BackingField");
			CleanerUIElement.NativeMethodInfoPtr_get_AssignedCleaner_Public_get_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100683050);
			CleanerUIElement.NativeMethodInfoPtr_set_AssignedCleaner_Protected_set_Void_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100683051);
			CleanerUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100683052);
			CleanerUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100683053);
			CleanerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100683054);
		}

		// Token: 0x1700312B RID: 12587
		// (get) Token: 0x0600A041 RID: 41025 RVA: 0x0028A82C File Offset: 0x00288A2C
		// (set) Token: 0x0600A042 RID: 41026 RVA: 0x0028A86C File Offset: 0x00288A6C
		public unsafe Cleaner AssignedCleaner
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerUIElement.NativeMethodInfoPtr_get_AssignedCleaner_Public_get_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerUIElement.NativeMethodInfoPtr_set_AssignedCleaner_Protected_set_Void_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A043 RID: 41027 RVA: 0x0028A8B0 File Offset: 0x00288AB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284038, RefRangeEnd = 284039, XrefRangeStart = 284027, XrefRangeEnd = 284038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Cleaner cleaner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cleaner);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A044 RID: 41028 RVA: 0x0028A8F4 File Offset: 0x00288AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284039, XrefRangeEnd = 284051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A045 RID: 41029 RVA: 0x0028A930 File Offset: 0x00288B30
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanerUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A046 RID: 41030 RVA: 0x0004E673 File Offset: 0x0004C873
		public CleanerUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003129 RID: 12585
		// (get) Token: 0x0600A047 RID: 41031 RVA: 0x0028A96C File Offset: 0x00288B6C
		// (set) Token: 0x0600A048 RID: 41032 RVA: 0x0004E67C File Offset: 0x0004C87C
		public unsafe Il2CppReferenceArray<Image> StationsIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerUIElement.NativeFieldInfoPtr_StationsIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerUIElement.NativeFieldInfoPtr_StationsIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700312A RID: 12586
		// (get) Token: 0x0600A049 RID: 41033 RVA: 0x0028A99C File Offset: 0x00288B9C
		// (set) Token: 0x0600A04A RID: 41034 RVA: 0x0004E69B File Offset: 0x0004C89B
		public unsafe Cleaner _AssignedCleaner_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerUIElement.NativeFieldInfoPtr__AssignedCleaner_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerUIElement.NativeFieldInfoPtr__AssignedCleaner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006B9D RID: 27549
		private static readonly IntPtr NativeFieldInfoPtr_StationsIcons;

		// Token: 0x04006B9E RID: 27550
		private static readonly IntPtr NativeFieldInfoPtr__AssignedCleaner_k__BackingField;

		// Token: 0x04006B9F RID: 27551
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedCleaner_Public_get_Cleaner_0;

		// Token: 0x04006BA0 RID: 27552
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedCleaner_Protected_set_Void_Cleaner_0;

		// Token: 0x04006BA1 RID: 27553
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Cleaner_0;

		// Token: 0x04006BA2 RID: 27554
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006BA3 RID: 27555
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
