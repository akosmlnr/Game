using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000759 RID: 1881
	public class Toilet : GridItem
	{
		// Token: 0x0600AA51 RID: 43601 RVA: 0x002AAE48 File Offset: 0x002A9048
		// Note: this type is marked as 'beforefieldinit'.
		static Toilet()
		{
			Il2CppClassPointerStore<Toilet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Toilet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Toilet>.NativeClassPtr);
			Toilet.NativeFieldInfoPtr_InitialDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "InitialDelay");
			Toilet.NativeFieldInfoPtr_FlushTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "FlushTime");
			Toilet.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "IntObj");
			Toilet.NativeFieldInfoPtr_ItemLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "ItemLayerMask");
			Toilet.NativeFieldInfoPtr_ItemDetectionCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "ItemDetectionCollider");
			Toilet.NativeFieldInfoPtr_OnFlush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "OnFlush");
			Toilet.NativeFieldInfoPtr__flushCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "_flushCoroutine");
			Toilet.NativeFieldInfoPtr_isFlushing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "isFlushing");
			Toilet.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.ToiletAssembly-CSharp.dll_Excuted");
			Toilet.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.ToiletAssembly-CSharp.dll_Excuted");
			Toilet.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100684248);
			Toilet.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100684249);
			Toilet.NativeMethodInfoPtr_SendFlush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100684250);
			Toilet.NativeMethodInfoPtr_Flush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100684251);
			Toilet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100684252);
			Toilet.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100684253);
			Toilet.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100684254);
			Toilet.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100684255);
			Toilet.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100684256);
			Toilet.NativeMethodInfoPtr_RpcWriter___Server_SendFlush_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100684257);
			Toilet.NativeMethodInfoPtr_RpcLogic___SendFlush_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100684258);
			Toilet.NativeMethodInfoPtr_RpcReader___Server_SendFlush_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100684259);
			Toilet.NativeMethodInfoPtr_RpcWriter___Observers_Flush_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100684260);
			Toilet.NativeMethodInfoPtr_RpcLogic___Flush_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100684261);
			Toilet.NativeMethodInfoPtr_RpcReader___Observers_Flush_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100684262);
			Toilet.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100684263);
		}

		// Token: 0x0600AA52 RID: 43602 RVA: 0x002AB080 File Offset: 0x002A9280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296573, XrefRangeEnd = 296574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA53 RID: 43603 RVA: 0x002AB0B4 File Offset: 0x002A92B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296574, XrefRangeEnd = 296583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA54 RID: 43604 RVA: 0x002AB0E8 File Offset: 0x002A92E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296583, XrefRangeEnd = 296592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendFlush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_SendFlush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA55 RID: 43605 RVA: 0x002AB11C File Offset: 0x002A931C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296592, XrefRangeEnd = 296601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_Flush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA56 RID: 43606 RVA: 0x002AB150 File Offset: 0x002A9350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296601, XrefRangeEnd = 296602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Toilet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Toilet>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA57 RID: 43607 RVA: 0x002AB18C File Offset: 0x002A938C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296602, XrefRangeEnd = 296607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600AA58 RID: 43608 RVA: 0x002AB1CC File Offset: 0x002A93CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296607, XrefRangeEnd = 296622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toilet.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA59 RID: 43609 RVA: 0x002AB208 File Offset: 0x002A9408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296622, XrefRangeEnd = 296623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toilet.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA5A RID: 43610 RVA: 0x002AB244 File Offset: 0x002A9444
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 184680, RefRangeEnd = 184686, XrefRangeStart = 184680, XrefRangeEnd = 184686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toilet.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA5B RID: 43611 RVA: 0x002AB280 File Offset: 0x002A9480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendFlush_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcWriter___Server_SendFlush_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA5C RID: 43612 RVA: 0x002AB2B4 File Offset: 0x002A94B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendFlush_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcLogic___SendFlush_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA5D RID: 43613 RVA: 0x002AB2E8 File Offset: 0x002A94E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296623, XrefRangeEnd = 296633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendFlush_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcReader___Server_SendFlush_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA5E RID: 43614 RVA: 0x002AB34C File Offset: 0x002A954C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Flush_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcWriter___Observers_Flush_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA5F RID: 43615 RVA: 0x002AB380 File Offset: 0x002A9580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296633, XrefRangeEnd = 296640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Flush_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcLogic___Flush_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA60 RID: 43616 RVA: 0x002AB3B4 File Offset: 0x002A95B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296640, XrefRangeEnd = 296648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Flush_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcReader___Observers_Flush_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA61 RID: 43617 RVA: 0x002AB404 File Offset: 0x002A9604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296649, RefRangeEnd = 296650, XrefRangeStart = 296648, XrefRangeEnd = 296649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toilet.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA62 RID: 43618 RVA: 0x00053B06 File Offset: 0x00051D06
		public Toilet(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700345D RID: 13405
		// (get) Token: 0x0600AA63 RID: 43619 RVA: 0x002AB440 File Offset: 0x002A9640
		// (set) Token: 0x0600AA64 RID: 43620 RVA: 0x00053B0F File Offset: 0x00051D0F
		public unsafe float InitialDelay
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_InitialDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_InitialDelay)) = value;
			}
		}

		// Token: 0x1700345E RID: 13406
		// (get) Token: 0x0600AA65 RID: 43621 RVA: 0x002AB468 File Offset: 0x002A9668
		// (set) Token: 0x0600AA66 RID: 43622 RVA: 0x00053B2A File Offset: 0x00051D2A
		public unsafe float FlushTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_FlushTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_FlushTime)) = value;
			}
		}

		// Token: 0x1700345F RID: 13407
		// (get) Token: 0x0600AA67 RID: 43623 RVA: 0x002AB490 File Offset: 0x002A9690
		// (set) Token: 0x0600AA68 RID: 43624 RVA: 0x00053B45 File Offset: 0x00051D45
		public unsafe InteractableObject IntObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_IntObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003460 RID: 13408
		// (get) Token: 0x0600AA69 RID: 43625 RVA: 0x002AB4C0 File Offset: 0x002A96C0
		// (set) Token: 0x0600AA6A RID: 43626 RVA: 0x00053B64 File Offset: 0x00051D64
		public unsafe LayerMask ItemLayerMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_ItemLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_ItemLayerMask)) = value;
			}
		}

		// Token: 0x17003461 RID: 13409
		// (get) Token: 0x0600AA6B RID: 43627 RVA: 0x002AB4E8 File Offset: 0x002A96E8
		// (set) Token: 0x0600AA6C RID: 43628 RVA: 0x00053B7F File Offset: 0x00051D7F
		public unsafe SphereCollider ItemDetectionCollider
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_ItemDetectionCollider);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereCollider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_ItemDetectionCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003462 RID: 13410
		// (get) Token: 0x0600AA6D RID: 43629 RVA: 0x002AB518 File Offset: 0x002A9718
		// (set) Token: 0x0600AA6E RID: 43630 RVA: 0x00053B9E File Offset: 0x00051D9E
		public unsafe UnityEvent OnFlush
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_OnFlush);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_OnFlush), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003463 RID: 13411
		// (get) Token: 0x0600AA6F RID: 43631 RVA: 0x002AB548 File Offset: 0x002A9748
		// (set) Token: 0x0600AA70 RID: 43632 RVA: 0x00053BBD File Offset: 0x00051DBD
		public unsafe Coroutine _flushCoroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr__flushCoroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr__flushCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003464 RID: 13412
		// (get) Token: 0x0600AA71 RID: 43633 RVA: 0x002AB578 File Offset: 0x002A9778
		// (set) Token: 0x0600AA72 RID: 43634 RVA: 0x00053BDC File Offset: 0x00051DDC
		public unsafe bool isFlushing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_isFlushing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_isFlushing)) = value;
			}
		}

		// Token: 0x17003465 RID: 13413
		// (get) Token: 0x0600AA73 RID: 43635 RVA: 0x002AB5A0 File Offset: 0x002A97A0
		// (set) Token: 0x0600AA74 RID: 43636 RVA: 0x00053BF7 File Offset: 0x00051DF7
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003466 RID: 13414
		// (get) Token: 0x0600AA75 RID: 43637 RVA: 0x002AB5C8 File Offset: 0x002A97C8
		// (set) Token: 0x0600AA76 RID: 43638 RVA: 0x00053C12 File Offset: 0x00051E12
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007247 RID: 29255
		private static readonly System.IntPtr NativeFieldInfoPtr_InitialDelay;

		// Token: 0x04007248 RID: 29256
		private static readonly System.IntPtr NativeFieldInfoPtr_FlushTime;

		// Token: 0x04007249 RID: 29257
		private static readonly System.IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x0400724A RID: 29258
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemLayerMask;

		// Token: 0x0400724B RID: 29259
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemDetectionCollider;

		// Token: 0x0400724C RID: 29260
		private static readonly System.IntPtr NativeFieldInfoPtr_OnFlush;

		// Token: 0x0400724D RID: 29261
		private static readonly System.IntPtr NativeFieldInfoPtr__flushCoroutine;

		// Token: 0x0400724E RID: 29262
		private static readonly System.IntPtr NativeFieldInfoPtr_isFlushing;

		// Token: 0x0400724F RID: 29263
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007250 RID: 29264
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007251 RID: 29265
		private static readonly System.IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04007252 RID: 29266
		private static readonly System.IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04007253 RID: 29267
		private static readonly System.IntPtr NativeMethodInfoPtr_SendFlush_Private_Void_0;

		// Token: 0x04007254 RID: 29268
		private static readonly System.IntPtr NativeMethodInfoPtr_Flush_Private_Void_0;

		// Token: 0x04007255 RID: 29269
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007256 RID: 29270
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04007257 RID: 29271
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04007258 RID: 29272
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04007259 RID: 29273
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400725A RID: 29274
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendFlush_2166136261_Private_Void_0;

		// Token: 0x0400725B RID: 29275
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendFlush_2166136261_Private_Void_0;

		// Token: 0x0400725C RID: 29276
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendFlush_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400725D RID: 29277
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Flush_2166136261_Private_Void_0;

		// Token: 0x0400725E RID: 29278
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___Flush_2166136261_Private_Void_0;

		// Token: 0x0400725F RID: 29279
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_Flush_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007260 RID: 29280
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000C2E RID: 3118
		[ObfuscatedName("ScheduleOne.ObjectScripts.Toilet+<<Flush>g__Routine|11_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E420 RID: 58400 RVA: 0x0035ED2C File Offset: 0x0035CF2C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique()
			{
				Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "<<Flush>g__Routine|11_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<>1__state");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<>2__current");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<>4__this");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__checkRate_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<checkRate>5__2");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__reps_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<reps>5__3");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<i>5__4");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100684264);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100684265);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100684266);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100684267);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100684268);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100684269);
			}

			// Token: 0x0600E421 RID: 58401 RVA: 0x0035EE48 File Offset: 0x0035D048
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E422 RID: 58402 RVA: 0x0035EE90 File Offset: 0x0035D090
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E423 RID: 58403 RVA: 0x0035EEC4 File Offset: 0x0035D0C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296517, XrefRangeEnd = 296568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x1700466E RID: 18030
			// (get) Token: 0x0600E424 RID: 58404 RVA: 0x0035EF00 File Offset: 0x0035D100
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E425 RID: 58405 RVA: 0x0035EF40 File Offset: 0x0035D140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296568, XrefRangeEnd = 296573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x1700466F RID: 18031
			// (get) Token: 0x0600E426 RID: 58406 RVA: 0x0035EF74 File Offset: 0x0035D174
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E427 RID: 58407 RVA: 0x0006EEC8 File Offset: 0x0006D0C8
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004668 RID: 18024
			// (get) Token: 0x0600E428 RID: 58408 RVA: 0x0035EFB4 File Offset: 0x0035D1B4
			// (set) Token: 0x0600E429 RID: 58409 RVA: 0x0006EED1 File Offset: 0x0006D0D1
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004669 RID: 18025
			// (get) Token: 0x0600E42A RID: 58410 RVA: 0x0035EFDC File Offset: 0x0035D1DC
			// (set) Token: 0x0600E42B RID: 58411 RVA: 0x0006EEEC File Offset: 0x0006D0EC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700466A RID: 18026
			// (get) Token: 0x0600E42C RID: 58412 RVA: 0x0035F00C File Offset: 0x0035D20C
			// (set) Token: 0x0600E42D RID: 58413 RVA: 0x0006EF0B File Offset: 0x0006D10B
			public unsafe Toilet __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toilet>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700466B RID: 18027
			// (get) Token: 0x0600E42E RID: 58414 RVA: 0x0035F03C File Offset: 0x0035D23C
			// (set) Token: 0x0600E42F RID: 58415 RVA: 0x0006EF2A File Offset: 0x0006D12A
			public unsafe float _checkRate_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__checkRate_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__checkRate_5__2)) = value;
				}
			}

			// Token: 0x1700466C RID: 18028
			// (get) Token: 0x0600E430 RID: 58416 RVA: 0x0035F064 File Offset: 0x0035D264
			// (set) Token: 0x0600E431 RID: 58417 RVA: 0x0006EF45 File Offset: 0x0006D145
			public unsafe int _reps_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__reps_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__reps_5__3)) = value;
				}
			}

			// Token: 0x1700466D RID: 18029
			// (get) Token: 0x0600E432 RID: 58418 RVA: 0x0035F08C File Offset: 0x0035D28C
			// (set) Token: 0x0600E433 RID: 58419 RVA: 0x0006EF60 File Offset: 0x0006D160
			public unsafe int _i_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x040098C8 RID: 39112
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040098C9 RID: 39113
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040098CA RID: 39114
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040098CB RID: 39115
			private static readonly System.IntPtr NativeFieldInfoPtr__checkRate_5__2;

			// Token: 0x040098CC RID: 39116
			private static readonly System.IntPtr NativeFieldInfoPtr__reps_5__3;

			// Token: 0x040098CD RID: 39117
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x040098CE RID: 39118
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040098CF RID: 39119
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040098D0 RID: 39120
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040098D1 RID: 39121
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040098D2 RID: 39122
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040098D3 RID: 39123
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
