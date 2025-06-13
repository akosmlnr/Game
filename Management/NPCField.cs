using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003B4 RID: 948
	public class NPCField : ConfigField
	{
		// Token: 0x06004957 RID: 18775 RVA: 0x00168660 File Offset: 0x00166860
		// Note: this type is marked as 'beforefieldinit'.
		static NPCField()
		{
			Il2CppClassPointerStore<NPCField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "NPCField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCField>.NativeClassPtr);
			NPCField.NativeFieldInfoPtr__SelectedNPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCField>.NativeClassPtr, "<SelectedNPC>k__BackingField");
			NPCField.NativeFieldInfoPtr_TypeRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCField>.NativeClassPtr, "TypeRequirement");
			NPCField.NativeFieldInfoPtr_onNPCChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCField>.NativeClassPtr, "onNPCChanged");
			NPCField.NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672441);
			NPCField.NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672442);
			NPCField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672443);
			NPCField.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672444);
			NPCField.NativeMethodInfoPtr_DoesNPCMatchRequirement_Public_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672445);
			NPCField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672446);
			NPCField.NativeMethodInfoPtr_GetData_Public_NPCFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672447);
			NPCField.NativeMethodInfoPtr_Load_Public_Void_NPCFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100672448);
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x06004958 RID: 18776 RVA: 0x0016876C File Offset: 0x0016696C
		// (set) Token: 0x06004959 RID: 18777 RVA: 0x001687AC File Offset: 0x001669AC
		public unsafe NPC SelectedNPC
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x001687F0 File Offset: 0x001669F0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 165985, RefRangeEnd = 165993, XrefRangeStart = 165977, XrefRangeEnd = 165985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCField>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600495B RID: 18779 RVA: 0x0016883C File Offset: 0x00166A3C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 166002, RefRangeEnd = 166016, XrefRangeStart = 165993, XrefRangeEnd = 166002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNPC(NPC npc, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600495C RID: 18780 RVA: 0x0016888C File Offset: 0x00166A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166016, XrefRangeEnd = 166020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesNPCMatchRequirement(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_DoesNPCMatchRequirement_Public_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x001688DC File Offset: 0x00166ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166020, XrefRangeEnd = 166024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600495E RID: 18782 RVA: 0x00168924 File Offset: 0x00166B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166024, XrefRangeEnd = 166036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_GetData_Public_NPCFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCFieldData>(intPtr2) : null;
		}

		// Token: 0x0600495F RID: 18783 RVA: 0x00168964 File Offset: 0x00166B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166036, XrefRangeEnd = 166049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(NPCFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_Load_Public_Void_NPCFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004960 RID: 18784 RVA: 0x000234C7 File Offset: 0x000216C7
		public NPCField(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x06004961 RID: 18785 RVA: 0x001689A8 File Offset: 0x00166BA8
		// (set) Token: 0x06004962 RID: 18786 RVA: 0x000234D0 File Offset: 0x000216D0
		public unsafe NPC _SelectedNPC_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr__SelectedNPC_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr__SelectedNPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x06004963 RID: 18787 RVA: 0x001689D8 File Offset: 0x00166BD8
		// (set) Token: 0x06004964 RID: 18788 RVA: 0x000234EF File Offset: 0x000216EF
		public unsafe Il2CppSystem.Type TypeRequirement
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr_TypeRequirement);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr_TypeRequirement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x06004965 RID: 18789 RVA: 0x00168A08 File Offset: 0x00166C08
		// (set) Token: 0x06004966 RID: 18790 RVA: 0x0002350E File Offset: 0x0002170E
		public unsafe UnityEvent<NPC> onNPCChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr_onNPCChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<NPC>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr_onNPCChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003166 RID: 12646
		private static readonly System.IntPtr NativeFieldInfoPtr__SelectedNPC_k__BackingField;

		// Token: 0x04003167 RID: 12647
		private static readonly System.IntPtr NativeFieldInfoPtr_TypeRequirement;

		// Token: 0x04003168 RID: 12648
		private static readonly System.IntPtr NativeFieldInfoPtr_onNPCChanged;

		// Token: 0x04003169 RID: 12649
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0;

		// Token: 0x0400316A RID: 12650
		private static readonly System.IntPtr NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0;

		// Token: 0x0400316B RID: 12651
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x0400316C RID: 12652
		private static readonly System.IntPtr NativeMethodInfoPtr_SetNPC_Public_Void_NPC_Boolean_0;

		// Token: 0x0400316D RID: 12653
		private static readonly System.IntPtr NativeMethodInfoPtr_DoesNPCMatchRequirement_Public_Boolean_NPC_0;

		// Token: 0x0400316E RID: 12654
		private static readonly System.IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x0400316F RID: 12655
		private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Public_NPCFieldData_0;

		// Token: 0x04003170 RID: 12656
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_NPCFieldData_0;
	}
}
