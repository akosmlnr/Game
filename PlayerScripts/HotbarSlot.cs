using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003FF RID: 1023
	public class HotbarSlot : ItemSlot
	{
		// Token: 0x06004E18 RID: 19992 RVA: 0x001786A0 File Offset: 0x001768A0
		// Note: this type is marked as 'beforefieldinit'.
		static HotbarSlot()
		{
			Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "HotbarSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr);
			HotbarSlot.NativeFieldInfoPtr__IsEquipped_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, "<IsEquipped>k__BackingField");
			HotbarSlot.NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, "Equippable");
			HotbarSlot.NativeFieldInfoPtr_onEquipChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, "onEquipChanged");
			HotbarSlot.NativeMethodInfoPtr_get_IsEquipped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100673009);
			HotbarSlot.NativeMethodInfoPtr_set_IsEquipped_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100673010);
			HotbarSlot.NativeMethodInfoPtr_SetStoredItem_Public_Virtual_Void_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100673011);
			HotbarSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100673012);
			HotbarSlot.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100673013);
			HotbarSlot.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100673014);
			HotbarSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100673015);
			HotbarSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100673016);
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x06004E19 RID: 19993 RVA: 0x001787AC File Offset: 0x001769AC
		// (set) Token: 0x06004E1A RID: 19994 RVA: 0x001787E8 File Offset: 0x001769E8
		public unsafe bool IsEquipped
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.NativeMethodInfoPtr_get_IsEquipped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.NativeMethodInfoPtr_set_IsEquipped_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x00178828 File Offset: 0x00176A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170342, XrefRangeEnd = 170369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetStoredItem(ItemInstance instance, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _internal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_SetStoredItem_Public_Virtual_Void_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E1C RID: 19996 RVA: 0x00178884 File Offset: 0x00176A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170369, XrefRangeEnd = 170376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearStoredInstance(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _internal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E1D RID: 19997 RVA: 0x001788D0 File Offset: 0x00176AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170376, XrefRangeEnd = 170398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Equip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x0017890C File Offset: 0x00176B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170398, XrefRangeEnd = 170403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E1F RID: 19999 RVA: 0x00178948 File Offset: 0x00176B48
		[CallerCount(176)]
		[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanSlotAcceptCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004E20 RID: 20000 RVA: 0x00178990 File Offset: 0x00176B90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170404, RefRangeEnd = 170407, XrefRangeStart = 170403, XrefRangeEnd = 170404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HotbarSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E21 RID: 20001 RVA: 0x00025626 File Offset: 0x00023826
		public HotbarSlot(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x06004E22 RID: 20002 RVA: 0x001789CC File Offset: 0x00176BCC
		// (set) Token: 0x06004E23 RID: 20003 RVA: 0x0002562F File Offset: 0x0002382F
		public unsafe bool _IsEquipped_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr__IsEquipped_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr__IsEquipped_k__BackingField)) = value;
			}
		}

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06004E24 RID: 20004 RVA: 0x001789F4 File Offset: 0x00176BF4
		// (set) Token: 0x06004E25 RID: 20005 RVA: 0x0002564A File Offset: 0x0002384A
		public unsafe Equippable Equippable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr_Equippable);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x06004E26 RID: 20006 RVA: 0x00178A24 File Offset: 0x00176C24
		// (set) Token: 0x06004E27 RID: 20007 RVA: 0x00025669 File Offset: 0x00023869
		public unsafe HotbarSlot.EquipEvent onEquipChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr_onEquipChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HotbarSlot.EquipEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr_onEquipChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003490 RID: 13456
		private static readonly System.IntPtr NativeFieldInfoPtr__IsEquipped_k__BackingField;

		// Token: 0x04003491 RID: 13457
		private static readonly System.IntPtr NativeFieldInfoPtr_Equippable;

		// Token: 0x04003492 RID: 13458
		private static readonly System.IntPtr NativeFieldInfoPtr_onEquipChanged;

		// Token: 0x04003493 RID: 13459
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEquipped_Public_get_Boolean_0;

		// Token: 0x04003494 RID: 13460
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsEquipped_Protected_set_Void_Boolean_0;

		// Token: 0x04003495 RID: 13461
		private static readonly System.IntPtr NativeMethodInfoPtr_SetStoredItem_Public_Virtual_Void_ItemInstance_Boolean_0;

		// Token: 0x04003496 RID: 13462
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0;

		// Token: 0x04003497 RID: 13463
		private static readonly System.IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_0;

		// Token: 0x04003498 RID: 13464
		private static readonly System.IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0;

		// Token: 0x04003499 RID: 13465
		private static readonly System.IntPtr NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0;

		// Token: 0x0400349A RID: 13466
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009D6 RID: 2518
		public sealed class EquipEvent : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600CF6F RID: 53103 RVA: 0x00324878 File Offset: 0x00322A78
			// Note: this type is marked as 'beforefieldinit'.
			static EquipEvent()
			{
				Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, "EquipEvent");
				HotbarSlot.EquipEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr, 100673017);
				HotbarSlot.EquipEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr, 100673018);
				HotbarSlot.EquipEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr, 100673019);
				HotbarSlot.EquipEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr, 100673020);
			}

			// Token: 0x0600CF70 RID: 53104 RVA: 0x003248EC File Offset: 0x00322AEC
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 170295, RefRangeEnd = 170338, XrefRangeStart = 170292, XrefRangeEnd = 170295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EquipEvent(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.EquipEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF71 RID: 53105 RVA: 0x00324948 File Offset: 0x00322B48
			[CallerCount(0)]
			public unsafe void Invoke(bool equipped)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref equipped;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.EquipEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF72 RID: 53106 RVA: 0x00324988 File Offset: 0x00322B88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170338, XrefRangeEnd = 170342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(bool equipped, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref equipped;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.EquipEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600CF73 RID: 53107 RVA: 0x003249F8 File Offset: 0x00322BF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.EquipEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF74 RID: 53108 RVA: 0x00064890 File Offset: 0x00062A90
			public EquipEvent(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CF75 RID: 53109 RVA: 0x00064899 File Offset: 0x00062A99
			public static implicit operator HotbarSlot.EquipEvent(System.Action<bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<HotbarSlot.EquipEvent>(A_0);
			}

			// Token: 0x0600CF76 RID: 53110 RVA: 0x000648A1 File Offset: 0x00062AA1
			public static HotbarSlot.EquipEvent operator +(HotbarSlot.EquipEvent A_0, HotbarSlot.EquipEvent A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<HotbarSlot.EquipEvent>();
			}

			// Token: 0x0600CF77 RID: 53111 RVA: 0x000648AF File Offset: 0x00062AAF
			public static HotbarSlot.EquipEvent operator -(HotbarSlot.EquipEvent A_0, HotbarSlot.EquipEvent A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<HotbarSlot.EquipEvent>();
				}
				return result;
			}

			// Token: 0x04008C5D RID: 35933
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008C5E RID: 35934
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0;

			// Token: 0x04008C5F RID: 35935
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0;

			// Token: 0x04008C60 RID: 35936
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
