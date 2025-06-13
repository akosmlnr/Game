using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x02000703 RID: 1795
	public class MixingStationUIElement : WorldspaceUIElement
	{
		// Token: 0x0600A05F RID: 41055 RVA: 0x0028AE40 File Offset: 0x00289040
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationUIElement()
		{
			Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "MixingStationUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr);
			MixingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, "<AssignedStation>k__BackingField");
			MixingStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100683065);
			MixingStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100683066);
			MixingStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100683067);
			MixingStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100683068);
			MixingStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100683069);
		}

		// Token: 0x17003132 RID: 12594
		// (get) Token: 0x0600A060 RID: 41056 RVA: 0x0028AEE8 File Offset: 0x002890E8
		// (set) Token: 0x0600A061 RID: 41057 RVA: 0x0028AF28 File Offset: 0x00289128
		public unsafe MixingStation AssignedStation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17870, RefRangeEnd = 17871, XrefRangeStart = 17870, XrefRangeEnd = 17871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 40500, RefRangeEnd = 40502, XrefRangeStart = 40500, XrefRangeEnd = 40502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A062 RID: 41058 RVA: 0x0028AF6C File Offset: 0x0028916C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284097, RefRangeEnd = 284098, XrefRangeStart = 284087, XrefRangeEnd = 284097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(MixingStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A063 RID: 41059 RVA: 0x0028AFB0 File Offset: 0x002891B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284098, XrefRangeEnd = 284103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A064 RID: 41060 RVA: 0x0028AFEC File Offset: 0x002891EC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A065 RID: 41061 RVA: 0x0004E729 File Offset: 0x0004C929
		public MixingStationUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003131 RID: 12593
		// (get) Token: 0x0600A066 RID: 41062 RVA: 0x0028B028 File Offset: 0x00289228
		// (set) Token: 0x0600A067 RID: 41063 RVA: 0x0004E732 File Offset: 0x0004C932
		public unsafe MixingStation _AssignedStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BB1 RID: 27569
		private static readonly IntPtr NativeFieldInfoPtr__AssignedStation_k__BackingField;

		// Token: 0x04006BB2 RID: 27570
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedStation_Public_get_MixingStation_0;

		// Token: 0x04006BB3 RID: 27571
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_MixingStation_0;

		// Token: 0x04006BB4 RID: 27572
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_MixingStation_0;

		// Token: 0x04006BB5 RID: 27573
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006BB6 RID: 27574
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
