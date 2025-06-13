using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x02000535 RID: 1333
	public class RV : Property
	{
		// Token: 0x06007567 RID: 30055 RVA: 0x002027B0 File Offset: 0x002009B0
		// Note: this type is marked as 'beforefieldinit'.
		static RV()
		{
			Il2CppClassPointerStore<RV>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "RV");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RV>.NativeClassPtr);
			RV.NativeFieldInfoPtr_ModelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV>.NativeClassPtr, "ModelContainer");
			RV.NativeFieldInfoPtr_FXContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV>.NativeClassPtr, "FXContainer");
			RV.NativeFieldInfoPtr_onSetExploded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV>.NativeClassPtr, "onSetExploded");
			RV.NativeFieldInfoPtr___isExploded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV>.NativeClassPtr, "<_isExploded>k__BackingField");
			RV.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.RVAssembly-CSharp.dll_Excuted");
			RV.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.RVAssembly-CSharp.dll_Excuted");
			RV.NativeMethodInfoPtr_get__isExploded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100678141);
			RV.NativeMethodInfoPtr_set__isExploded_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100678142);
			RV.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100678143);
			RV.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100678144);
			RV.NativeMethodInfoPtr_UpdateVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100678145);
			RV.NativeMethodInfoPtr_Ransack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100678146);
			RV.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100678147);
			RV.NativeMethodInfoPtr_SetExploded_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100678148);
			RV.NativeMethodInfoPtr_SetExploded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100678149);
			RV.NativeMethodInfoPtr_OnSleep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100678150);
			RV.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100678151);
			RV.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100678152);
			RV.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100678153);
			RV.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100678154);
			RV.NativeMethodInfoPtr_RpcWriter___Target_SetExploded_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100678155);
			RV.NativeMethodInfoPtr_RpcLogic___SetExploded_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100678156);
			RV.NativeMethodInfoPtr_RpcReader___Target_SetExploded_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100678157);
			RV.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV>.NativeClassPtr, 100678158);
		}

		// Token: 0x17002371 RID: 9073
		// (get) Token: 0x06007568 RID: 30056 RVA: 0x002029C0 File Offset: 0x00200BC0
		// (set) Token: 0x06007569 RID: 30057 RVA: 0x002029FC File Offset: 0x00200BFC
		public unsafe bool _isExploded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_get__isExploded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_set__isExploded_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600756A RID: 30058 RVA: 0x00202A3C File Offset: 0x00200C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229693, XrefRangeEnd = 229709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600756B RID: 30059 RVA: 0x00202A78 File Offset: 0x00200C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229709, XrefRangeEnd = 229710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600756C RID: 30060 RVA: 0x00202AC8 File Offset: 0x00200CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229710, XrefRangeEnd = 229805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_UpdateVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600756D RID: 30061 RVA: 0x00202AFC File Offset: 0x00200CFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229858, RefRangeEnd = 229859, XrefRangeStart = 229805, XrefRangeEnd = 229858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Ransack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_Ransack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600756E RID: 30062 RVA: 0x00202B30 File Offset: 0x00200D30
		[CallerCount(0)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600756F RID: 30063 RVA: 0x00202B78 File Offset: 0x00200D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229859, XrefRangeEnd = 229868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExploded(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_SetExploded_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007570 RID: 30064 RVA: 0x00202BBC File Offset: 0x00200DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229868, XrefRangeEnd = 229869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExploded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_SetExploded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007571 RID: 30065 RVA: 0x00202BF0 File Offset: 0x00200DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229869, XrefRangeEnd = 229875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSleep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_OnSleep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007572 RID: 30066 RVA: 0x00202C24 File Offset: 0x00200E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229875, XrefRangeEnd = 229879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RV() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RV>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007573 RID: 30067 RVA: 0x00202C60 File Offset: 0x00200E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229879, XrefRangeEnd = 229887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007574 RID: 30068 RVA: 0x00202C9C File Offset: 0x00200E9C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007575 RID: 30069 RVA: 0x00202CD8 File Offset: 0x00200ED8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007576 RID: 30070 RVA: 0x00202D14 File Offset: 0x00200F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetExploded_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_RpcWriter___Target_SetExploded_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007577 RID: 30071 RVA: 0x00202D58 File Offset: 0x00200F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetExploded_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_RpcLogic___SetExploded_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007578 RID: 30072 RVA: 0x00202D9C File Offset: 0x00200F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229887, XrefRangeEnd = 229890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetExploded_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.NativeMethodInfoPtr_RpcReader___Target_SetExploded_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007579 RID: 30073 RVA: 0x00202DEC File Offset: 0x00200FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RV.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600757A RID: 30074 RVA: 0x00037943 File Offset: 0x00035B43
		public RV(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700236B RID: 9067
		// (get) Token: 0x0600757B RID: 30075 RVA: 0x00202E28 File Offset: 0x00201028
		// (set) Token: 0x0600757C RID: 30076 RVA: 0x0003794C File Offset: 0x00035B4C
		public unsafe Transform ModelContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_ModelContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_ModelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700236C RID: 9068
		// (get) Token: 0x0600757D RID: 30077 RVA: 0x00202E58 File Offset: 0x00201058
		// (set) Token: 0x0600757E RID: 30078 RVA: 0x0003796B File Offset: 0x00035B6B
		public unsafe Transform FXContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_FXContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_FXContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700236D RID: 9069
		// (get) Token: 0x0600757F RID: 30079 RVA: 0x00202E88 File Offset: 0x00201088
		// (set) Token: 0x06007580 RID: 30080 RVA: 0x0003798A File Offset: 0x00035B8A
		public unsafe UnityEvent onSetExploded
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_onSetExploded);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_onSetExploded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700236E RID: 9070
		// (get) Token: 0x06007581 RID: 30081 RVA: 0x00202EB8 File Offset: 0x002010B8
		// (set) Token: 0x06007582 RID: 30082 RVA: 0x000379A9 File Offset: 0x00035BA9
		public unsafe bool __isExploded_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr___isExploded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr___isExploded_k__BackingField)) = value;
			}
		}

		// Token: 0x1700236F RID: 9071
		// (get) Token: 0x06007583 RID: 30083 RVA: 0x00202EE0 File Offset: 0x002010E0
		// (set) Token: 0x06007584 RID: 30084 RVA: 0x000379C4 File Offset: 0x00035BC4
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002370 RID: 9072
		// (get) Token: 0x06007585 RID: 30085 RVA: 0x00202F08 File Offset: 0x00201108
		// (set) Token: 0x06007586 RID: 30086 RVA: 0x000379DF File Offset: 0x00035BDF
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RV.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04005027 RID: 20519
		private static readonly System.IntPtr NativeFieldInfoPtr_ModelContainer;

		// Token: 0x04005028 RID: 20520
		private static readonly System.IntPtr NativeFieldInfoPtr_FXContainer;

		// Token: 0x04005029 RID: 20521
		private static readonly System.IntPtr NativeFieldInfoPtr_onSetExploded;

		// Token: 0x0400502A RID: 20522
		private static readonly System.IntPtr NativeFieldInfoPtr___isExploded_k__BackingField;

		// Token: 0x0400502B RID: 20523
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400502C RID: 20524
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400502D RID: 20525
		private static readonly System.IntPtr NativeMethodInfoPtr_get__isExploded_Public_get_Boolean_0;

		// Token: 0x0400502E RID: 20526
		private static readonly System.IntPtr NativeMethodInfoPtr_set__isExploded_Private_set_Void_Boolean_0;

		// Token: 0x0400502F RID: 20527
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005030 RID: 20528
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04005031 RID: 20529
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVariables_Private_Void_0;

		// Token: 0x04005032 RID: 20530
		private static readonly System.IntPtr NativeMethodInfoPtr_Ransack_Public_Void_0;

		// Token: 0x04005033 RID: 20531
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04005034 RID: 20532
		private static readonly System.IntPtr NativeMethodInfoPtr_SetExploded_Public_Void_NetworkConnection_0;

		// Token: 0x04005035 RID: 20533
		private static readonly System.IntPtr NativeMethodInfoPtr_SetExploded_Public_Void_0;

		// Token: 0x04005036 RID: 20534
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSleep_Private_Void_0;

		// Token: 0x04005037 RID: 20535
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005038 RID: 20536
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005039 RID: 20537
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400503A RID: 20538
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400503B RID: 20539
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetExploded_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x0400503C RID: 20540
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetExploded_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x0400503D RID: 20541
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetExploded_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400503E RID: 20542
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000AD9 RID: 2777
		[ObfuscatedName("ScheduleOne.Property.RV+<>c")]
		[System.Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D778 RID: 55160 RVA: 0x0033AEAC File Offset: 0x003390AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RV.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RV>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RV.__c>.NativeClassPtr);
				RV.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, "<>9");
				RV.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, "<>9__9_0");
				RV.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, "<>9__9_1");
				RV.__c.NativeFieldInfoPtr___9__9_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, "<>9__9_2");
				RV.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, 100678160);
				RV.__c.NativeMethodInfoPtr__UpdateVariables_b__9_0_Internal_Boolean_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, 100678161);
				RV.__c.NativeMethodInfoPtr__UpdateVariables_b__9_1_Internal_Pot_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, 100678162);
				RV.__c.NativeMethodInfoPtr__UpdateVariables_b__9_2_Internal_Boolean_Additive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RV.__c>.NativeClassPtr, 100678163);
			}

			// Token: 0x0600D779 RID: 55161 RVA: 0x0033AF78 File Offset: 0x00339178
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RV.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D77A RID: 55162 RVA: 0x0033AFB4 File Offset: 0x003391B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229685, XrefRangeEnd = 229687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__9_0(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RV.__c.NativeMethodInfoPtr__UpdateVariables_b__9_0_Internal_Boolean_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D77B RID: 55163 RVA: 0x0033B004 File Offset: 0x00339204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229687, XrefRangeEnd = 229689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Pot _UpdateVariables_b__9_1(BuildableItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RV.__c.NativeMethodInfoPtr__UpdateVariables_b__9_1_Internal_Pot_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}

			// Token: 0x0600D77C RID: 55164 RVA: 0x0033B054 File Offset: 0x00339254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229689, XrefRangeEnd = 229693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__9_2(Additive x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RV.__c.NativeMethodInfoPtr__UpdateVariables_b__9_2_Internal_Boolean_Additive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D77D RID: 55165 RVA: 0x0006894F File Offset: 0x00066B4F
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700428C RID: 17036
			// (get) Token: 0x0600D77E RID: 55166 RVA: 0x0033B0A4 File Offset: 0x003392A4
			// (set) Token: 0x0600D77F RID: 55167 RVA: 0x00068958 File Offset: 0x00066B58
			public unsafe static RV.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RV.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RV.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RV.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700428D RID: 17037
			// (get) Token: 0x0600D780 RID: 55168 RVA: 0x0033B0CC File Offset: 0x003392CC
			// (set) Token: 0x0600D781 RID: 55169 RVA: 0x0006896A File Offset: 0x00066B6A
			public unsafe static Il2CppSystem.Func<BuildableItem, bool> __9__9_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RV.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<BuildableItem, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RV.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700428E RID: 17038
			// (get) Token: 0x0600D782 RID: 55170 RVA: 0x0033B0F4 File Offset: 0x003392F4
			// (set) Token: 0x0600D783 RID: 55171 RVA: 0x0006897C File Offset: 0x00066B7C
			public unsafe static Il2CppSystem.Func<BuildableItem, Pot> __9__9_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RV.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<BuildableItem, Pot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RV.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700428F RID: 17039
			// (get) Token: 0x0600D784 RID: 55172 RVA: 0x0033B11C File Offset: 0x0033931C
			// (set) Token: 0x0600D785 RID: 55173 RVA: 0x0006898E File Offset: 0x00066B8E
			public unsafe static Il2CppSystem.Predicate<Additive> __9__9_2
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RV.__c.NativeFieldInfoPtr___9__9_2, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Additive>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RV.__c.NativeFieldInfoPtr___9__9_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400915D RID: 37213
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400915E RID: 37214
			private static readonly System.IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x0400915F RID: 37215
			private static readonly System.IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04009160 RID: 37216
			private static readonly System.IntPtr NativeFieldInfoPtr___9__9_2;

			// Token: 0x04009161 RID: 37217
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009162 RID: 37218
			private static readonly System.IntPtr NativeMethodInfoPtr__UpdateVariables_b__9_0_Internal_Boolean_BuildableItem_0;

			// Token: 0x04009163 RID: 37219
			private static readonly System.IntPtr NativeMethodInfoPtr__UpdateVariables_b__9_1_Internal_Pot_BuildableItem_0;

			// Token: 0x04009164 RID: 37220
			private static readonly System.IntPtr NativeMethodInfoPtr__UpdateVariables_b__9_2_Internal_Boolean_Additive_0;
		}
	}
}
