using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Variables;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000608 RID: 1544
	public class ItemPickup : NetworkBehaviour
	{
		// Token: 0x060085EC RID: 34284 RVA: 0x0023B630 File Offset: 0x00239830
		// Note: this type is marked as 'beforefieldinit'.
		static ItemPickup()
		{
			Il2CppClassPointerStore<ItemPickup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemPickup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr);
			ItemPickup.NativeFieldInfoPtr_ItemToGive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "ItemToGive");
			ItemPickup.NativeFieldInfoPtr_DestroyOnPickup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "DestroyOnPickup");
			ItemPickup.NativeFieldInfoPtr_ConditionallyActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "ConditionallyActive");
			ItemPickup.NativeFieldInfoPtr_ActiveCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "ActiveCondition");
			ItemPickup.NativeFieldInfoPtr_Networked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "Networked");
			ItemPickup.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "IntObj");
			ItemPickup.NativeFieldInfoPtr_onPickup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "onPickup");
			ItemPickup.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ItemFramework.ItemPickupAssembly-CSharp.dll_Excuted");
			ItemPickup.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ItemFramework.ItemPickupAssembly-CSharp.dll_Excuted");
			ItemPickup.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100680138);
			ItemPickup.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100680139);
			ItemPickup.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100680140);
			ItemPickup.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100680141);
			ItemPickup.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100680142);
			ItemPickup.NativeMethodInfoPtr_CanPickup_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100680143);
			ItemPickup.NativeMethodInfoPtr_Pickup_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100680144);
			ItemPickup.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100680145);
			ItemPickup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100680146);
			ItemPickup.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100680147);
			ItemPickup.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100680148);
			ItemPickup.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100680149);
			ItemPickup.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100680150);
			ItemPickup.NativeMethodInfoPtr_RpcWriter___Server_Destroy_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100680151);
			ItemPickup.NativeMethodInfoPtr_RpcLogic___Destroy_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100680152);
			ItemPickup.NativeMethodInfoPtr_RpcReader___Server_Destroy_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100680153);
			ItemPickup.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, 100680154);
		}

		// Token: 0x060085ED RID: 34285 RVA: 0x0023B868 File Offset: 0x00239A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251351, XrefRangeEnd = 251371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemPickup.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085EE RID: 34286 RVA: 0x0023B8A4 File Offset: 0x00239AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251371, XrefRangeEnd = 251399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085EF RID: 34287 RVA: 0x0023B8D8 File Offset: 0x00239AD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 251430, RefRangeEnd = 251431, XrefRangeStart = 251399, XrefRangeEnd = 251430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085F0 RID: 34288 RVA: 0x0023B90C File Offset: 0x00239B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251431, XrefRangeEnd = 251435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemPickup.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085F1 RID: 34289 RVA: 0x0023B948 File Offset: 0x00239B48
		[CallerCount(0)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085F2 RID: 34290 RVA: 0x0023B97C File Offset: 0x00239B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251435, XrefRangeEnd = 251440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPickup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemPickup.NativeMethodInfoPtr_CanPickup_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060085F3 RID: 34291 RVA: 0x0023B9C4 File Offset: 0x00239BC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 251472, RefRangeEnd = 251473, XrefRangeStart = 251440, XrefRangeEnd = 251472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Pickup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemPickup.NativeMethodInfoPtr_Pickup_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085F4 RID: 34292 RVA: 0x0023BA00 File Offset: 0x00239C00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 251494, RefRangeEnd = 251495, XrefRangeStart = 251473, XrefRangeEnd = 251494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085F5 RID: 34293 RVA: 0x0023BA34 File Offset: 0x00239C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251495, XrefRangeEnd = 251496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemPickup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085F6 RID: 34294 RVA: 0x0023BA70 File Offset: 0x00239C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251496, XrefRangeEnd = 251501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060085F7 RID: 34295 RVA: 0x0023BAB0 File Offset: 0x00239CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251501, XrefRangeEnd = 251508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemPickup.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085F8 RID: 34296 RVA: 0x0023BAEC File Offset: 0x00239CEC
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemPickup.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085F9 RID: 34297 RVA: 0x0023BB28 File Offset: 0x00239D28
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemPickup.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085FA RID: 34298 RVA: 0x0023BB64 File Offset: 0x00239D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251508, XrefRangeEnd = 251517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_Destroy_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.NativeMethodInfoPtr_RpcWriter___Server_Destroy_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085FB RID: 34299 RVA: 0x0023BB98 File Offset: 0x00239D98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 251525, RefRangeEnd = 251528, XrefRangeStart = 251517, XrefRangeEnd = 251525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Destroy_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.NativeMethodInfoPtr_RpcLogic___Destroy_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085FC RID: 34300 RVA: 0x0023BBCC File Offset: 0x00239DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251528, XrefRangeEnd = 251531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_Destroy_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.NativeMethodInfoPtr_RpcReader___Server_Destroy_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085FD RID: 34301 RVA: 0x0023BC30 File Offset: 0x00239E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251531, XrefRangeEnd = 251551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemPickup.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085FE RID: 34302 RVA: 0x0003F582 File Offset: 0x0003D782
		public ItemPickup(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700284D RID: 10317
		// (get) Token: 0x060085FF RID: 34303 RVA: 0x0023BC6C File Offset: 0x00239E6C
		// (set) Token: 0x06008600 RID: 34304 RVA: 0x0003F58B File Offset: 0x0003D78B
		public unsafe ItemDefinition ItemToGive
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_ItemToGive);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_ItemToGive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700284E RID: 10318
		// (get) Token: 0x06008601 RID: 34305 RVA: 0x0023BC9C File Offset: 0x00239E9C
		// (set) Token: 0x06008602 RID: 34306 RVA: 0x0003F5AA File Offset: 0x0003D7AA
		public unsafe bool DestroyOnPickup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_DestroyOnPickup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_DestroyOnPickup)) = value;
			}
		}

		// Token: 0x1700284F RID: 10319
		// (get) Token: 0x06008603 RID: 34307 RVA: 0x0023BCC4 File Offset: 0x00239EC4
		// (set) Token: 0x06008604 RID: 34308 RVA: 0x0003F5C5 File Offset: 0x0003D7C5
		public unsafe bool ConditionallyActive
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_ConditionallyActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_ConditionallyActive)) = value;
			}
		}

		// Token: 0x17002850 RID: 10320
		// (get) Token: 0x06008605 RID: 34309 RVA: 0x0023BCEC File Offset: 0x00239EEC
		// (set) Token: 0x06008606 RID: 34310 RVA: 0x0003F5E0 File Offset: 0x0003D7E0
		public unsafe Condition ActiveCondition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_ActiveCondition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Condition>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_ActiveCondition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002851 RID: 10321
		// (get) Token: 0x06008607 RID: 34311 RVA: 0x0023BD1C File Offset: 0x00239F1C
		// (set) Token: 0x06008608 RID: 34312 RVA: 0x0003F5FF File Offset: 0x0003D7FF
		public unsafe bool Networked
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_Networked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_Networked)) = value;
			}
		}

		// Token: 0x17002852 RID: 10322
		// (get) Token: 0x06008609 RID: 34313 RVA: 0x0023BD44 File Offset: 0x00239F44
		// (set) Token: 0x0600860A RID: 34314 RVA: 0x0003F61A File Offset: 0x0003D81A
		public unsafe InteractableObject IntObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_IntObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002853 RID: 10323
		// (get) Token: 0x0600860B RID: 34315 RVA: 0x0023BD74 File Offset: 0x00239F74
		// (set) Token: 0x0600860C RID: 34316 RVA: 0x0003F639 File Offset: 0x0003D839
		public unsafe UnityEvent onPickup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_onPickup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_onPickup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002854 RID: 10324
		// (get) Token: 0x0600860D RID: 34317 RVA: 0x0023BDA4 File Offset: 0x00239FA4
		// (set) Token: 0x0600860E RID: 34318 RVA: 0x0003F658 File Offset: 0x0003D858
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002855 RID: 10325
		// (get) Token: 0x0600860F RID: 34319 RVA: 0x0023BDCC File Offset: 0x00239FCC
		// (set) Token: 0x06008610 RID: 34320 RVA: 0x0003F673 File Offset: 0x0003D873
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04005B2D RID: 23341
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemToGive;

		// Token: 0x04005B2E RID: 23342
		private static readonly System.IntPtr NativeFieldInfoPtr_DestroyOnPickup;

		// Token: 0x04005B2F RID: 23343
		private static readonly System.IntPtr NativeFieldInfoPtr_ConditionallyActive;

		// Token: 0x04005B30 RID: 23344
		private static readonly System.IntPtr NativeFieldInfoPtr_ActiveCondition;

		// Token: 0x04005B31 RID: 23345
		private static readonly System.IntPtr NativeFieldInfoPtr_Networked;

		// Token: 0x04005B32 RID: 23346
		private static readonly System.IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04005B33 RID: 23347
		private static readonly System.IntPtr NativeFieldInfoPtr_onPickup;

		// Token: 0x04005B34 RID: 23348
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005B35 RID: 23349
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005B36 RID: 23350
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04005B37 RID: 23351
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005B38 RID: 23352
		private static readonly System.IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04005B39 RID: 23353
		private static readonly System.IntPtr NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_1;

		// Token: 0x04005B3A RID: 23354
		private static readonly System.IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x04005B3B RID: 23355
		private static readonly System.IntPtr NativeMethodInfoPtr_CanPickup_Protected_Virtual_New_Boolean_0;

		// Token: 0x04005B3C RID: 23356
		private static readonly System.IntPtr NativeMethodInfoPtr_Pickup_Protected_Virtual_New_Void_1;

		// Token: 0x04005B3D RID: 23357
		private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x04005B3E RID: 23358
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005B3F RID: 23359
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04005B40 RID: 23360
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005B41 RID: 23361
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04005B42 RID: 23362
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04005B43 RID: 23363
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_Destroy_2166136261_Private_Void_0;

		// Token: 0x04005B44 RID: 23364
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___Destroy_2166136261_Public_Void_0;

		// Token: 0x04005B45 RID: 23365
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_Destroy_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005B46 RID: 23366
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000B35 RID: 2869
		[ObfuscatedName("ScheduleOne.ItemFramework.ItemPickup+<<Init>g__Wait|9_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DA71 RID: 55921 RVA: 0x00343538 File Offset: 0x00341738
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique()
			{
				Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "<<Init>g__Wait|9_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr);
				ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr, "<>1__state");
				ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr, "<>2__current");
				ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr, "<>4__this");
				ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr, 100680155);
				ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr, 100680156);
				ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr, 100680157);
				ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr, 100680158);
				ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr, 100680159);
				ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr, 100680160);
			}

			// Token: 0x0600DA72 RID: 55922 RVA: 0x00343618 File Offset: 0x00341818
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA73 RID: 55923 RVA: 0x00343660 File Offset: 0x00341860
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA74 RID: 55924 RVA: 0x00343694 File Offset: 0x00341894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251322, XrefRangeEnd = 251342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004364 RID: 17252
			// (get) Token: 0x0600DA75 RID: 55925 RVA: 0x003436D0 File Offset: 0x003418D0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DA76 RID: 55926 RVA: 0x00343710 File Offset: 0x00341910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251342, XrefRangeEnd = 251347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004365 RID: 17253
			// (get) Token: 0x0600DA77 RID: 55927 RVA: 0x00343744 File Offset: 0x00341944
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DA78 RID: 55928 RVA: 0x00069F55 File Offset: 0x00068155
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004361 RID: 17249
			// (get) Token: 0x0600DA79 RID: 55929 RVA: 0x00343784 File Offset: 0x00341984
			// (set) Token: 0x0600DA7A RID: 55930 RVA: 0x00069F5E File Offset: 0x0006815E
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004362 RID: 17250
			// (get) Token: 0x0600DA7B RID: 55931 RVA: 0x003437AC File Offset: 0x003419AC
			// (set) Token: 0x0600DA7C RID: 55932 RVA: 0x00069F79 File Offset: 0x00068179
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004363 RID: 17251
			// (get) Token: 0x0600DA7D RID: 55933 RVA: 0x003437DC File Offset: 0x003419DC
			// (set) Token: 0x0600DA7E RID: 55934 RVA: 0x00069F98 File Offset: 0x00068198
			public unsafe ItemPickup __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemPickup>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemPickup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObItObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009305 RID: 37637
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009306 RID: 37638
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009307 RID: 37639
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009308 RID: 37640
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009309 RID: 37641
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400930A RID: 37642
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400930B RID: 37643
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400930C RID: 37644
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400930D RID: 37645
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B36 RID: 2870
		[ObfuscatedName("ScheduleOne.ItemFramework.ItemPickup+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DA7F RID: 55935 RVA: 0x0034380C File Offset: 0x00341A0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ItemPickup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemPickup>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemPickup.__c>.NativeClassPtr);
				ItemPickup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup.__c>.NativeClassPtr, "<>9");
				ItemPickup.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPickup.__c>.NativeClassPtr, "<>9__9_1");
				ItemPickup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup.__c>.NativeClassPtr, 100680162);
				ItemPickup.__c.NativeMethodInfoPtr__Init_b__9_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPickup.__c>.NativeClassPtr, 100680163);
			}

			// Token: 0x0600DA80 RID: 55936 RVA: 0x00343888 File Offset: 0x00341A88
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemPickup.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemPickup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA81 RID: 55937 RVA: 0x003438C4 File Offset: 0x00341AC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251347, XrefRangeEnd = 251351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Init_b__9_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemPickup.__c.NativeMethodInfoPtr__Init_b__9_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DA82 RID: 55938 RVA: 0x00069FB7 File Offset: 0x000681B7
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004366 RID: 17254
			// (get) Token: 0x0600DA83 RID: 55939 RVA: 0x00343900 File Offset: 0x00341B00
			// (set) Token: 0x0600DA84 RID: 55940 RVA: 0x00069FC0 File Offset: 0x000681C0
			public unsafe static ItemPickup.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ItemPickup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemPickup.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ItemPickup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004367 RID: 17255
			// (get) Token: 0x0600DA85 RID: 55941 RVA: 0x00343928 File Offset: 0x00341B28
			// (set) Token: 0x0600DA86 RID: 55942 RVA: 0x00069FD2 File Offset: 0x000681D2
			public unsafe static Il2CppSystem.Func<bool> __9__9_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ItemPickup.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ItemPickup.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400930E RID: 37646
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400930F RID: 37647
			private static readonly System.IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04009310 RID: 37648
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009311 RID: 37649
			private static readonly System.IntPtr NativeMethodInfoPtr__Init_b__9_1_Internal_Boolean_0;
		}
	}
}
