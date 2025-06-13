using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000612 RID: 1554
	[System.Serializable]
	public class SlotFilter : Il2CppSystem.Object
	{
		// Token: 0x060086CC RID: 34508 RVA: 0x0023EC5C File Offset: 0x0023CE5C
		// Note: this type is marked as 'beforefieldinit'.
		static SlotFilter()
		{
			Il2CppClassPointerStore<SlotFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "SlotFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotFilter>.NativeClassPtr);
			SlotFilter.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotFilter>.NativeClassPtr, "Type");
			SlotFilter.NativeFieldInfoPtr_ItemIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotFilter>.NativeClassPtr, "ItemIDs");
			SlotFilter.NativeFieldInfoPtr_AllowedQualities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotFilter>.NativeClassPtr, "AllowedQualities");
			SlotFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotFilter>.NativeClassPtr, 100680271);
			SlotFilter.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotFilter>.NativeClassPtr, 100680272);
			SlotFilter.NativeMethodInfoPtr_IsDefault_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotFilter>.NativeClassPtr, 100680273);
			SlotFilter.NativeMethodInfoPtr_Clone_Public_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotFilter>.NativeClassPtr, 100680274);
		}

		// Token: 0x060086CD RID: 34509 RVA: 0x0023ED18 File Offset: 0x0023CF18
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 252924, RefRangeEnd = 252932, XrefRangeStart = 252881, XrefRangeEnd = 252924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlotFilter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotFilter>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060086CE RID: 34510 RVA: 0x0023ED54 File Offset: 0x0023CF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252932, XrefRangeEnd = 252942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SlotFilter.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060086CF RID: 34511 RVA: 0x0023EDA4 File Offset: 0x0023CFA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 252944, RefRangeEnd = 252947, XrefRangeStart = 252942, XrefRangeEnd = 252944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SlotFilter.NativeMethodInfoPtr_IsDefault_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060086D0 RID: 34512 RVA: 0x0023EDE0 File Offset: 0x0023CFE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252965, RefRangeEnd = 252967, XrefRangeStart = 252947, XrefRangeEnd = 252965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlotFilter Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotFilter.NativeMethodInfoPtr_Clone_Public_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlotFilter>(intPtr2) : null;
		}

		// Token: 0x060086D1 RID: 34513 RVA: 0x0003FA02 File Offset: 0x0003DC02
		public SlotFilter(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002886 RID: 10374
		// (get) Token: 0x060086D2 RID: 34514 RVA: 0x0023EE20 File Offset: 0x0023D020
		// (set) Token: 0x060086D3 RID: 34515 RVA: 0x0003FA0B File Offset: 0x0003DC0B
		public unsafe SlotFilter.EType Type
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotFilter.NativeFieldInfoPtr_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotFilter.NativeFieldInfoPtr_Type)) = value;
			}
		}

		// Token: 0x17002887 RID: 10375
		// (get) Token: 0x060086D4 RID: 34516 RVA: 0x0023EE48 File Offset: 0x0023D048
		// (set) Token: 0x060086D5 RID: 34517 RVA: 0x0003FA26 File Offset: 0x0003DC26
		public unsafe List<string> ItemIDs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotFilter.NativeFieldInfoPtr_ItemIDs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotFilter.NativeFieldInfoPtr_ItemIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002888 RID: 10376
		// (get) Token: 0x060086D6 RID: 34518 RVA: 0x0023EE78 File Offset: 0x0023D078
		// (set) Token: 0x060086D7 RID: 34519 RVA: 0x0003FA45 File Offset: 0x0003DC45
		public unsafe List<EQuality> AllowedQualities
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotFilter.NativeFieldInfoPtr_AllowedQualities);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EQuality>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotFilter.NativeFieldInfoPtr_AllowedQualities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BD7 RID: 23511
		private static readonly System.IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04005BD8 RID: 23512
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemIDs;

		// Token: 0x04005BD9 RID: 23513
		private static readonly System.IntPtr NativeFieldInfoPtr_AllowedQualities;

		// Token: 0x04005BDA RID: 23514
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005BDB RID: 23515
		private static readonly System.IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Boolean_ItemInstance_0;

		// Token: 0x04005BDC RID: 23516
		private static readonly System.IntPtr NativeMethodInfoPtr_IsDefault_Public_Boolean_0;

		// Token: 0x04005BDD RID: 23517
		private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_SlotFilter_0;

		// Token: 0x02000B37 RID: 2871
		[OriginalName("Assembly-CSharp.dll", "", "EType")]
		public enum EType
		{
			// Token: 0x04009313 RID: 37651
			None,
			// Token: 0x04009314 RID: 37652
			Whitelist,
			// Token: 0x04009315 RID: 37653
			Blacklist
		}
	}
}
