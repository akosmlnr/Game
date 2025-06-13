using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.NPCs.Relation
{
	// Token: 0x02000312 RID: 786
	[System.Serializable]
	public class NPCRelationData : Il2CppSystem.Object
	{
		// Token: 0x06003A5E RID: 14942 RVA: 0x00131C90 File Offset: 0x0012FE90
		// Note: this type is marked as 'beforefieldinit'.
		static NPCRelationData()
		{
			Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Relation", "NPCRelationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr);
			NPCRelationData.NativeFieldInfoPtr_MinDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "MinDelta");
			NPCRelationData.NativeFieldInfoPtr_MaxDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "MaxDelta");
			NPCRelationData.NativeFieldInfoPtr_DEFAULT_RELATION_DELTA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "DEFAULT_RELATION_DELTA");
			NPCRelationData.NativeFieldInfoPtr__RelationDelta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<RelationDelta>k__BackingField");
			NPCRelationData.NativeFieldInfoPtr__Unlocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<Unlocked>k__BackingField");
			NPCRelationData.NativeFieldInfoPtr__UnlockType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<UnlockType>k__BackingField");
			NPCRelationData.NativeFieldInfoPtr__NPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<NPC>k__BackingField");
			NPCRelationData.NativeFieldInfoPtr_FullGameConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "FullGameConnections");
			NPCRelationData.NativeFieldInfoPtr_DemoConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "DemoConnections");
			NPCRelationData.NativeFieldInfoPtr_onRelationshipChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "onRelationshipChange");
			NPCRelationData.NativeFieldInfoPtr_onUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "onUnlocked");
			NPCRelationData.NativeMethodInfoPtr_get_RelationDelta_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670169);
			NPCRelationData.NativeMethodInfoPtr_set_RelationDelta_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670170);
			NPCRelationData.NativeMethodInfoPtr_get_NormalizedRelationDelta_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670171);
			NPCRelationData.NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670172);
			NPCRelationData.NativeMethodInfoPtr_set_Unlocked_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670173);
			NPCRelationData.NativeMethodInfoPtr_get_UnlockType_Public_get_EUnlockType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670174);
			NPCRelationData.NativeMethodInfoPtr_set_UnlockType_Protected_set_Void_EUnlockType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670175);
			NPCRelationData.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670176);
			NPCRelationData.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670177);
			NPCRelationData.NativeMethodInfoPtr_get_Connections_Public_get_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670178);
			NPCRelationData.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670179);
			NPCRelationData.NativeMethodInfoPtr_Init_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670180);
			NPCRelationData.NativeMethodInfoPtr_ChangeRelationship_Public_Virtual_New_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670181);
			NPCRelationData.NativeMethodInfoPtr_SetRelationship_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670182);
			NPCRelationData.NativeMethodInfoPtr_Unlock_Public_Virtual_New_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670183);
			NPCRelationData.NativeMethodInfoPtr_UnlockConnections_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670184);
			NPCRelationData.NativeMethodInfoPtr_GetSaveData_Public_RelationshipData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670185);
			NPCRelationData.NativeMethodInfoPtr_GetAverageMutualRelationship_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670186);
			NPCRelationData.NativeMethodInfoPtr_IsKnown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670187);
			NPCRelationData.NativeMethodInfoPtr_IsMutuallyKnown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670188);
			NPCRelationData.NativeMethodInfoPtr_GetLockedConnections_Public_List_1_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670189);
			NPCRelationData.NativeMethodInfoPtr_GetLockedDealers_Public_List_1_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670190);
			NPCRelationData.NativeMethodInfoPtr_GetLockedSuppliers_Public_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670191);
			NPCRelationData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100670192);
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x06003A5F RID: 14943 RVA: 0x00131F7C File Offset: 0x0013017C
		// (set) Token: 0x06003A60 RID: 14944 RVA: 0x00131FB8 File Offset: 0x001301B8
		public unsafe float RelationDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_RelationDelta_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31384, RefRangeEnd = 31388, XrefRangeStart = 31384, XrefRangeEnd = 31388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_set_RelationDelta_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x06003A61 RID: 14945 RVA: 0x00131FF8 File Offset: 0x001301F8
		public unsafe float NormalizedRelationDelta
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 147211, RefRangeEnd = 147221, XrefRangeStart = 147211, XrefRangeEnd = 147211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_NormalizedRelationDelta_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x06003A62 RID: 14946 RVA: 0x00132034 File Offset: 0x00130234
		// (set) Token: 0x06003A63 RID: 14947 RVA: 0x00132070 File Offset: 0x00130270
		public unsafe bool Unlocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_set_Unlocked_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x06003A64 RID: 14948 RVA: 0x001320B0 File Offset: 0x001302B0
		// (set) Token: 0x06003A65 RID: 14949 RVA: 0x001320EC File Offset: 0x001302EC
		public unsafe NPCRelationData.EUnlockType UnlockType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21910, RefRangeEnd = 21913, XrefRangeStart = 21910, XrefRangeEnd = 21913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_UnlockType_Public_get_EUnlockType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31462, RefRangeEnd = 31464, XrefRangeStart = 31462, XrefRangeEnd = 31464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_set_UnlockType_Protected_set_Void_EUnlockType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x06003A66 RID: 14950 RVA: 0x0013212C File Offset: 0x0013032C
		// (set) Token: 0x06003A67 RID: 14951 RVA: 0x0013216C File Offset: 0x0013036C
		public unsafe NPC NPC
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x06003A68 RID: 14952 RVA: 0x001321B0 File Offset: 0x001303B0
		public unsafe List<NPC> Connections
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_Connections_Public_get_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
		}

		// Token: 0x06003A69 RID: 14953 RVA: 0x001321F0 File Offset: 0x001303F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A6A RID: 14954 RVA: 0x00132234 File Offset: 0x00130434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147245, RefRangeEnd = 147246, XrefRangeStart = 147221, XrefRangeEnd = 147245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_Init_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x00132278 File Offset: 0x00130478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147246, XrefRangeEnd = 147248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ChangeRelationship(float deltaChange, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref deltaChange;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCRelationData.NativeMethodInfoPtr_ChangeRelationship_Public_Virtual_New_Void_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A6C RID: 14956 RVA: 0x001322D0 File Offset: 0x001304D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147248, XrefRangeEnd = 147249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetRelationship(float newDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref newDelta;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCRelationData.NativeMethodInfoPtr_SetRelationship_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A6D RID: 14957 RVA: 0x0013231C File Offset: 0x0013051C
		[CallerCount(0)]
		public unsafe virtual void Unlock(NPCRelationData.EUnlockType type, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref notify;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCRelationData.NativeMethodInfoPtr_Unlock_Public_Virtual_New_Void_EUnlockType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A6E RID: 14958 RVA: 0x00132374 File Offset: 0x00130574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147249, XrefRangeEnd = 147256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnlockConnections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCRelationData.NativeMethodInfoPtr_UnlockConnections_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A6F RID: 14959 RVA: 0x001323B0 File Offset: 0x001305B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147260, RefRangeEnd = 147261, XrefRangeStart = 147256, XrefRangeEnd = 147260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationshipData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetSaveData_Public_RelationshipData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationshipData>(intPtr2) : null;
		}

		// Token: 0x06003A70 RID: 14960 RVA: 0x001323F0 File Offset: 0x001305F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 147268, RefRangeEnd = 147270, XrefRangeStart = 147261, XrefRangeEnd = 147268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAverageMutualRelationship()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetAverageMutualRelationship_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06003A71 RID: 14961 RVA: 0x0013242C File Offset: 0x0013062C
		[CallerCount(0)]
		public unsafe bool IsKnown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_IsKnown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06003A72 RID: 14962 RVA: 0x00132468 File Offset: 0x00130668
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 147281, RefRangeEnd = 147289, XrefRangeStart = 147270, XrefRangeEnd = 147281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMutuallyKnown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_IsMutuallyKnown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06003A73 RID: 14963 RVA: 0x001324A4 File Offset: 0x001306A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147289, XrefRangeEnd = 147303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPC> GetLockedConnections(bool excludeCustomers = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref excludeCustomers;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetLockedConnections_Public_List_1_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
		}

		// Token: 0x06003A74 RID: 14964 RVA: 0x001324F0 File Offset: 0x001306F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147317, RefRangeEnd = 147318, XrefRangeStart = 147303, XrefRangeEnd = 147317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPC> GetLockedDealers(bool excludeRecommended)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref excludeRecommended;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetLockedDealers_Public_List_1_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
		}

		// Token: 0x06003A75 RID: 14965 RVA: 0x0013253C File Offset: 0x0013073C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147337, RefRangeEnd = 147338, XrefRangeStart = 147318, XrefRangeEnd = 147337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPC> GetLockedSuppliers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetLockedSuppliers_Public_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
		}

		// Token: 0x06003A76 RID: 14966 RVA: 0x0013257C File Offset: 0x0013077C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147338, XrefRangeEnd = 147351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCRelationData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A77 RID: 14967 RVA: 0x0001DCE4 File Offset: 0x0001BEE4
		public NPCRelationData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x06003A78 RID: 14968 RVA: 0x001325B8 File Offset: 0x001307B8
		// (set) Token: 0x06003A79 RID: 14969 RVA: 0x0001DCED File Offset: 0x0001BEED
		public unsafe static float MinDelta
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCRelationData.NativeFieldInfoPtr_MinDelta, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCRelationData.NativeFieldInfoPtr_MinDelta, (void*)(&value));
			}
		}

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x06003A7A RID: 14970 RVA: 0x001325D4 File Offset: 0x001307D4
		// (set) Token: 0x06003A7B RID: 14971 RVA: 0x0001DCFB File Offset: 0x0001BEFB
		public unsafe static float MaxDelta
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCRelationData.NativeFieldInfoPtr_MaxDelta, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCRelationData.NativeFieldInfoPtr_MaxDelta, (void*)(&value));
			}
		}

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x06003A7C RID: 14972 RVA: 0x001325F0 File Offset: 0x001307F0
		// (set) Token: 0x06003A7D RID: 14973 RVA: 0x0001DD09 File Offset: 0x0001BF09
		public unsafe static float DEFAULT_RELATION_DELTA
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCRelationData.NativeFieldInfoPtr_DEFAULT_RELATION_DELTA, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCRelationData.NativeFieldInfoPtr_DEFAULT_RELATION_DELTA, (void*)(&value));
			}
		}

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x06003A7E RID: 14974 RVA: 0x0013260C File Offset: 0x0013080C
		// (set) Token: 0x06003A7F RID: 14975 RVA: 0x0001DD17 File Offset: 0x0001BF17
		public unsafe float _RelationDelta_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__RelationDelta_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__RelationDelta_k__BackingField)) = value;
			}
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x06003A80 RID: 14976 RVA: 0x00132634 File Offset: 0x00130834
		// (set) Token: 0x06003A81 RID: 14977 RVA: 0x0001DD32 File Offset: 0x0001BF32
		public unsafe bool _Unlocked_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__Unlocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__Unlocked_k__BackingField)) = value;
			}
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x06003A82 RID: 14978 RVA: 0x0013265C File Offset: 0x0013085C
		// (set) Token: 0x06003A83 RID: 14979 RVA: 0x0001DD4D File Offset: 0x0001BF4D
		public unsafe NPCRelationData.EUnlockType _UnlockType_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__UnlockType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__UnlockType_k__BackingField)) = value;
			}
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x06003A84 RID: 14980 RVA: 0x00132684 File Offset: 0x00130884
		// (set) Token: 0x06003A85 RID: 14981 RVA: 0x0001DD68 File Offset: 0x0001BF68
		public unsafe NPC _NPC_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__NPC_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__NPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x06003A86 RID: 14982 RVA: 0x001326B4 File Offset: 0x001308B4
		// (set) Token: 0x06003A87 RID: 14983 RVA: 0x0001DD87 File Offset: 0x0001BF87
		public unsafe List<NPC> FullGameConnections
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_FullGameConnections);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_FullGameConnections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x06003A88 RID: 14984 RVA: 0x001326E4 File Offset: 0x001308E4
		// (set) Token: 0x06003A89 RID: 14985 RVA: 0x0001DDA6 File Offset: 0x0001BFA6
		public unsafe List<NPC> DemoConnections
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_DemoConnections);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_DemoConnections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x06003A8A RID: 14986 RVA: 0x00132714 File Offset: 0x00130914
		// (set) Token: 0x06003A8B RID: 14987 RVA: 0x0001DDC5 File Offset: 0x0001BFC5
		public unsafe Il2CppSystem.Action<float> onRelationshipChange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_onRelationshipChange);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_onRelationshipChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x06003A8C RID: 14988 RVA: 0x00132744 File Offset: 0x00130944
		// (set) Token: 0x06003A8D RID: 14989 RVA: 0x0001DDE4 File Offset: 0x0001BFE4
		public unsafe Il2CppSystem.Action<NPCRelationData.EUnlockType, bool> onUnlocked
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_onUnlocked);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<NPCRelationData.EUnlockType, bool>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_onUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002683 RID: 9859
		private static readonly System.IntPtr NativeFieldInfoPtr_MinDelta;

		// Token: 0x04002684 RID: 9860
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxDelta;

		// Token: 0x04002685 RID: 9861
		private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_RELATION_DELTA;

		// Token: 0x04002686 RID: 9862
		private static readonly System.IntPtr NativeFieldInfoPtr__RelationDelta_k__BackingField;

		// Token: 0x04002687 RID: 9863
		private static readonly System.IntPtr NativeFieldInfoPtr__Unlocked_k__BackingField;

		// Token: 0x04002688 RID: 9864
		private static readonly System.IntPtr NativeFieldInfoPtr__UnlockType_k__BackingField;

		// Token: 0x04002689 RID: 9865
		private static readonly System.IntPtr NativeFieldInfoPtr__NPC_k__BackingField;

		// Token: 0x0400268A RID: 9866
		private static readonly System.IntPtr NativeFieldInfoPtr_FullGameConnections;

		// Token: 0x0400268B RID: 9867
		private static readonly System.IntPtr NativeFieldInfoPtr_DemoConnections;

		// Token: 0x0400268C RID: 9868
		private static readonly System.IntPtr NativeFieldInfoPtr_onRelationshipChange;

		// Token: 0x0400268D RID: 9869
		private static readonly System.IntPtr NativeFieldInfoPtr_onUnlocked;

		// Token: 0x0400268E RID: 9870
		private static readonly System.IntPtr NativeMethodInfoPtr_get_RelationDelta_Public_get_Single_0;

		// Token: 0x0400268F RID: 9871
		private static readonly System.IntPtr NativeMethodInfoPtr_set_RelationDelta_Protected_set_Void_Single_0;

		// Token: 0x04002690 RID: 9872
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NormalizedRelationDelta_Public_get_Single_0;

		// Token: 0x04002691 RID: 9873
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0;

		// Token: 0x04002692 RID: 9874
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Unlocked_Protected_set_Void_Boolean_0;

		// Token: 0x04002693 RID: 9875
		private static readonly System.IntPtr NativeMethodInfoPtr_get_UnlockType_Public_get_EUnlockType_0;

		// Token: 0x04002694 RID: 9876
		private static readonly System.IntPtr NativeMethodInfoPtr_set_UnlockType_Protected_set_Void_EUnlockType_0;

		// Token: 0x04002695 RID: 9877
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NPC_Public_get_NPC_0;

		// Token: 0x04002696 RID: 9878
		private static readonly System.IntPtr NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0;

		// Token: 0x04002697 RID: 9879
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Connections_Public_get_List_1_NPC_0;

		// Token: 0x04002698 RID: 9880
		private static readonly System.IntPtr NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0;

		// Token: 0x04002699 RID: 9881
		private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_NPC_0;

		// Token: 0x0400269A RID: 9882
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangeRelationship_Public_Virtual_New_Void_Single_Boolean_0;

		// Token: 0x0400269B RID: 9883
		private static readonly System.IntPtr NativeMethodInfoPtr_SetRelationship_Public_Virtual_New_Void_Single_0;

		// Token: 0x0400269C RID: 9884
		private static readonly System.IntPtr NativeMethodInfoPtr_Unlock_Public_Virtual_New_Void_EUnlockType_Boolean_0;

		// Token: 0x0400269D RID: 9885
		private static readonly System.IntPtr NativeMethodInfoPtr_UnlockConnections_Public_Virtual_New_Void_0;

		// Token: 0x0400269E RID: 9886
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_RelationshipData_0;

		// Token: 0x0400269F RID: 9887
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAverageMutualRelationship_Public_Single_0;

		// Token: 0x040026A0 RID: 9888
		private static readonly System.IntPtr NativeMethodInfoPtr_IsKnown_Public_Boolean_0;

		// Token: 0x040026A1 RID: 9889
		private static readonly System.IntPtr NativeMethodInfoPtr_IsMutuallyKnown_Public_Boolean_0;

		// Token: 0x040026A2 RID: 9890
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLockedConnections_Public_List_1_NPC_Boolean_0;

		// Token: 0x040026A3 RID: 9891
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLockedDealers_Public_List_1_NPC_Boolean_0;

		// Token: 0x040026A4 RID: 9892
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLockedSuppliers_Public_List_1_NPC_0;

		// Token: 0x040026A5 RID: 9893
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000982 RID: 2434
		[OriginalName("Assembly-CSharp.dll", "", "EUnlockType")]
		public enum EUnlockType
		{
			// Token: 0x04008A48 RID: 35400
			Recommendation,
			// Token: 0x04008A49 RID: 35401
			DirectApproach
		}

		// Token: 0x02000983 RID: 2435
		[ObfuscatedName("ScheduleOne.NPCs.Relation.NPCRelationData+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CC39 RID: 52281 RVA: 0x0031AC5C File Offset: 0x00318E5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr);
				NPCRelationData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr, "<>9");
				NPCRelationData.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr, "<>9__40_0");
				NPCRelationData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr, 100670194);
				NPCRelationData.__c.NativeMethodInfoPtr__GetLockedSuppliers_b__40_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr, 100670195);
			}

			// Token: 0x0600CC3A RID: 52282 RVA: 0x0031ACD8 File Offset: 0x00318ED8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CC3B RID: 52283 RVA: 0x0031AD14 File Offset: 0x00318F14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147206, XrefRangeEnd = 147207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLockedSuppliers_b__40_0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c.NativeMethodInfoPtr__GetLockedSuppliers_b__40_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CC3C RID: 52284 RVA: 0x00063154 File Offset: 0x00061354
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F52 RID: 16210
			// (get) Token: 0x0600CC3D RID: 52285 RVA: 0x0031AD64 File Offset: 0x00318F64
			// (set) Token: 0x0600CC3E RID: 52286 RVA: 0x0006315D File Offset: 0x0006135D
			public unsafe static NPCRelationData.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCRelationData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCRelationData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCRelationData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F53 RID: 16211
			// (get) Token: 0x0600CC3F RID: 52287 RVA: 0x0031AD8C File Offset: 0x00318F8C
			// (set) Token: 0x0600CC40 RID: 52288 RVA: 0x0006316F File Offset: 0x0006136F
			public unsafe static Il2CppSystem.Predicate<NPC> __9__40_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCRelationData.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NPC>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCRelationData.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A4A RID: 35402
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008A4B RID: 35403
			private static readonly System.IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x04008A4C RID: 35404
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A4D RID: 35405
			private static readonly System.IntPtr NativeMethodInfoPtr__GetLockedSuppliers_b__40_0_Internal_Boolean_NPC_0;
		}

		// Token: 0x02000984 RID: 2436
		[ObfuscatedName("ScheduleOne.NPCs.Relation.NPCRelationData+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CC41 RID: 52289 RVA: 0x0031ADB4 File Offset: 0x00318FB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr);
				NPCRelationData.__c__DisplayClass38_0.NativeFieldInfoPtr_excludeCustomers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr, "excludeCustomers");
				NPCRelationData.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr, 100670196);
				NPCRelationData.__c__DisplayClass38_0.NativeMethodInfoPtr__GetLockedConnections_b__0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr, 100670197);
			}

			// Token: 0x0600CC42 RID: 52290 RVA: 0x0031AE1C File Offset: 0x0031901C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CC43 RID: 52291 RVA: 0x0031AE58 File Offset: 0x00319058
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147207, XrefRangeEnd = 147209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLockedConnections_b__0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c__DisplayClass38_0.NativeMethodInfoPtr__GetLockedConnections_b__0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CC44 RID: 52292 RVA: 0x00063181 File Offset: 0x00061381
			public __c__DisplayClass38_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F54 RID: 16212
			// (get) Token: 0x0600CC45 RID: 52293 RVA: 0x0031AEA8 File Offset: 0x003190A8
			// (set) Token: 0x0600CC46 RID: 52294 RVA: 0x0006318A File Offset: 0x0006138A
			public unsafe bool excludeCustomers
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.__c__DisplayClass38_0.NativeFieldInfoPtr_excludeCustomers);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.__c__DisplayClass38_0.NativeFieldInfoPtr_excludeCustomers)) = value;
				}
			}

			// Token: 0x04008A4E RID: 35406
			private static readonly System.IntPtr NativeFieldInfoPtr_excludeCustomers;

			// Token: 0x04008A4F RID: 35407
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A50 RID: 35408
			private static readonly System.IntPtr NativeMethodInfoPtr__GetLockedConnections_b__0_Internal_Boolean_NPC_0;
		}

		// Token: 0x02000985 RID: 2437
		[ObfuscatedName("ScheduleOne.NPCs.Relation.NPCRelationData+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CC47 RID: 52295 RVA: 0x0031AED0 File Offset: 0x003190D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr);
				NPCRelationData.__c__DisplayClass39_0.NativeFieldInfoPtr_excludeRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr, "excludeRecommended");
				NPCRelationData.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr, 100670198);
				NPCRelationData.__c__DisplayClass39_0.NativeMethodInfoPtr__GetLockedDealers_b__0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr, 100670199);
			}

			// Token: 0x0600CC48 RID: 52296 RVA: 0x0031AF38 File Offset: 0x00319138
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CC49 RID: 52297 RVA: 0x0031AF74 File Offset: 0x00319174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147209, XrefRangeEnd = 147211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLockedDealers_b__0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c__DisplayClass39_0.NativeMethodInfoPtr__GetLockedDealers_b__0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CC4A RID: 52298 RVA: 0x000631A5 File Offset: 0x000613A5
			public __c__DisplayClass39_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F55 RID: 16213
			// (get) Token: 0x0600CC4B RID: 52299 RVA: 0x0031AFC4 File Offset: 0x003191C4
			// (set) Token: 0x0600CC4C RID: 52300 RVA: 0x000631AE File Offset: 0x000613AE
			public unsafe bool excludeRecommended
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.__c__DisplayClass39_0.NativeFieldInfoPtr_excludeRecommended);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.__c__DisplayClass39_0.NativeFieldInfoPtr_excludeRecommended)) = value;
				}
			}

			// Token: 0x04008A51 RID: 35409
			private static readonly System.IntPtr NativeFieldInfoPtr_excludeRecommended;

			// Token: 0x04008A52 RID: 35410
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A53 RID: 35411
			private static readonly System.IntPtr NativeMethodInfoPtr__GetLockedDealers_b__0_Internal_Boolean_NPC_0;
		}
	}
}
