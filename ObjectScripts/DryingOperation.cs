using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000770 RID: 1904
	[System.Serializable]
	public class DryingOperation : Il2CppSystem.Object
	{
		// Token: 0x0600B076 RID: 45174 RVA: 0x002C24DC File Offset: 0x002C06DC
		// Note: this type is marked as 'beforefieldinit'.
		static DryingOperation()
		{
			Il2CppClassPointerStore<DryingOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "DryingOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr);
			DryingOperation.NativeFieldInfoPtr_ItemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, "ItemID");
			DryingOperation.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, "Quantity");
			DryingOperation.NativeFieldInfoPtr_StartQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, "StartQuality");
			DryingOperation.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, "Time");
			DryingOperation.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100685075);
			DryingOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100685076);
			DryingOperation.NativeMethodInfoPtr_IncreaseQuality_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100685077);
			DryingOperation.NativeMethodInfoPtr_GetQualityItemInstance_Public_QualityItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100685078);
			DryingOperation.NativeMethodInfoPtr_GetQuality_Public_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100685079);
		}

		// Token: 0x0600B077 RID: 45175 RVA: 0x002C25C0 File Offset: 0x002C07C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304814, XrefRangeEnd = 304816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingOperation(string itemID, int quantity, EQuality startQuality, int time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref startQuality;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref time;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EQuality_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B078 RID: 45176 RVA: 0x002C2638 File Offset: 0x002C0838
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B079 RID: 45177 RVA: 0x002C2674 File Offset: 0x002C0874
		[CallerCount(0)]
		public unsafe void IncreaseQuality()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr_IncreaseQuality_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B07A RID: 45178 RVA: 0x002C26A8 File Offset: 0x002C08A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304820, RefRangeEnd = 304821, XrefRangeStart = 304816, XrefRangeEnd = 304820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemInstance GetQualityItemInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr_GetQualityItemInstance_Public_QualityItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityItemInstance>(intPtr2) : null;
		}

		// Token: 0x0600B07B RID: 45179 RVA: 0x002C26E8 File Offset: 0x002C08E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 304821, RefRangeEnd = 304825, XrefRangeStart = 304821, XrefRangeEnd = 304821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EQuality GetQuality()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr_GetQuality_Public_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B07C RID: 45180 RVA: 0x000568A8 File Offset: 0x00054AA8
		public DryingOperation(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700366A RID: 13930
		// (get) Token: 0x0600B07D RID: 45181 RVA: 0x002C2724 File Offset: 0x002C0924
		// (set) Token: 0x0600B07E RID: 45182 RVA: 0x000568B1 File Offset: 0x00054AB1
		public unsafe string ItemID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_ItemID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_ItemID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700366B RID: 13931
		// (get) Token: 0x0600B07F RID: 45183 RVA: 0x002C274C File Offset: 0x002C094C
		// (set) Token: 0x0600B080 RID: 45184 RVA: 0x000568D0 File Offset: 0x00054AD0
		public unsafe int Quantity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x1700366C RID: 13932
		// (get) Token: 0x0600B081 RID: 45185 RVA: 0x002C2774 File Offset: 0x002C0974
		// (set) Token: 0x0600B082 RID: 45186 RVA: 0x000568EB File Offset: 0x00054AEB
		public unsafe EQuality StartQuality
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_StartQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_StartQuality)) = value;
			}
		}

		// Token: 0x1700366D RID: 13933
		// (get) Token: 0x0600B083 RID: 45187 RVA: 0x002C279C File Offset: 0x002C099C
		// (set) Token: 0x0600B084 RID: 45188 RVA: 0x00056906 File Offset: 0x00054B06
		public unsafe int Time
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_Time)) = value;
			}
		}

		// Token: 0x040076B3 RID: 30387
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemID;

		// Token: 0x040076B4 RID: 30388
		private static readonly System.IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x040076B5 RID: 30389
		private static readonly System.IntPtr NativeFieldInfoPtr_StartQuality;

		// Token: 0x040076B6 RID: 30390
		private static readonly System.IntPtr NativeFieldInfoPtr_Time;

		// Token: 0x040076B7 RID: 30391
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EQuality_Int32_0;

		// Token: 0x040076B8 RID: 30392
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040076B9 RID: 30393
		private static readonly System.IntPtr NativeMethodInfoPtr_IncreaseQuality_Public_Void_0;

		// Token: 0x040076BA RID: 30394
		private static readonly System.IntPtr NativeMethodInfoPtr_GetQualityItemInstance_Public_QualityItemInstance_0;

		// Token: 0x040076BB RID: 30395
		private static readonly System.IntPtr NativeMethodInfoPtr_GetQuality_Public_EQuality_0;
	}
}
