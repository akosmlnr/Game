using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x02000705 RID: 1797
	public class PackagingStationUIElement : WorldspaceUIElement
	{
		// Token: 0x0600A073 RID: 41075 RVA: 0x0028B2B4 File Offset: 0x002894B4
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingStationUIElement()
		{
			Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PackagingStationUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr);
			PackagingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, "<AssignedStation>k__BackingField");
			PackagingStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100683075);
			PackagingStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100683076);
			PackagingStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100683077);
			PackagingStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100683078);
			PackagingStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100683079);
		}

		// Token: 0x17003137 RID: 12599
		// (get) Token: 0x0600A074 RID: 41076 RVA: 0x0028B35C File Offset: 0x0028955C
		// (set) Token: 0x0600A075 RID: 41077 RVA: 0x0028B39C File Offset: 0x0028959C
		public unsafe PackagingStation AssignedStation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17870, RefRangeEnd = 17871, XrefRangeStart = 17870, XrefRangeEnd = 17871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 40500, RefRangeEnd = 40502, XrefRangeStart = 40500, XrefRangeEnd = 40502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A076 RID: 41078 RVA: 0x0028B3E0 File Offset: 0x002895E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284149, RefRangeEnd = 284150, XrefRangeStart = 284139, XrefRangeEnd = 284149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(PackagingStation pack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pack);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A077 RID: 41079 RVA: 0x0028B424 File Offset: 0x00289624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284150, XrefRangeEnd = 284155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A078 RID: 41080 RVA: 0x0028B460 File Offset: 0x00289660
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStationUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A079 RID: 41081 RVA: 0x0004E798 File Offset: 0x0004C998
		public PackagingStationUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003136 RID: 12598
		// (get) Token: 0x0600A07A RID: 41082 RVA: 0x0028B49C File Offset: 0x0028969C
		// (set) Token: 0x0600A07B RID: 41083 RVA: 0x0004E7A1 File Offset: 0x0004C9A1
		public unsafe PackagingStation _AssignedStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BBE RID: 27582
		private static readonly IntPtr NativeFieldInfoPtr__AssignedStation_k__BackingField;

		// Token: 0x04006BBF RID: 27583
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedStation_Public_get_PackagingStation_0;

		// Token: 0x04006BC0 RID: 27584
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_PackagingStation_0;

		// Token: 0x04006BC1 RID: 27585
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_PackagingStation_0;

		// Token: 0x04006BC2 RID: 27586
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006BC3 RID: 27587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
