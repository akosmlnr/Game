using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007AC RID: 1964
	public class NPCPoI : POI
	{
		// Token: 0x0600B9CA RID: 47562 RVA: 0x002E5550 File Offset: 0x002E3750
		// Note: this type is marked as 'beforefieldinit'.
		static NPCPoI()
		{
			Il2CppClassPointerStore<NPCPoI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "NPCPoI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr);
			NPCPoI.NativeFieldInfoPtr__NPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr, "<NPC>k__BackingField");
			NPCPoI.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr, 100686286);
			NPCPoI.NativeMethodInfoPtr_set_NPC_Private_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr, 100686287);
			NPCPoI.NativeMethodInfoPtr_InitializeUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr, 100686288);
			NPCPoI.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr, 100686289);
			NPCPoI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr, 100686290);
		}

		// Token: 0x1700394F RID: 14671
		// (get) Token: 0x0600B9CB RID: 47563 RVA: 0x002E55F8 File Offset: 0x002E37F8
		// (set) Token: 0x0600B9CC RID: 47564 RVA: 0x002E5638 File Offset: 0x002E3838
		public unsafe NPC NPC
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPoI.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPoI.NativeMethodInfoPtr_set_NPC_Private_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600B9CD RID: 47565 RVA: 0x002E567C File Offset: 0x002E387C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316692, XrefRangeEnd = 316707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCPoI.NativeMethodInfoPtr_InitializeUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9CE RID: 47566 RVA: 0x002E56B8 File Offset: 0x002E38B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 316722, RefRangeEnd = 316725, XrefRangeStart = 316707, XrefRangeEnd = 316722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPoI.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9CF RID: 47567 RVA: 0x002E56FC File Offset: 0x002E38FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316725, XrefRangeEnd = 316733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCPoI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCPoI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPoI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9D0 RID: 47568 RVA: 0x0005AD13 File Offset: 0x00058F13
		public NPCPoI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700394E RID: 14670
		// (get) Token: 0x0600B9D1 RID: 47569 RVA: 0x002E5738 File Offset: 0x002E3938
		// (set) Token: 0x0600B9D2 RID: 47570 RVA: 0x0005AD1C File Offset: 0x00058F1C
		public unsafe NPC _NPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPoI.NativeFieldInfoPtr__NPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPoI.NativeFieldInfoPtr__NPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007D53 RID: 32083
		private static readonly IntPtr NativeFieldInfoPtr__NPC_k__BackingField;

		// Token: 0x04007D54 RID: 32084
		private static readonly IntPtr NativeMethodInfoPtr_get_NPC_Public_get_NPC_0;

		// Token: 0x04007D55 RID: 32085
		private static readonly IntPtr NativeMethodInfoPtr_set_NPC_Private_set_Void_NPC_0;

		// Token: 0x04007D56 RID: 32086
		private static readonly IntPtr NativeMethodInfoPtr_InitializeUI_Public_Virtual_Void_0;

		// Token: 0x04007D57 RID: 32087
		private static readonly IntPtr NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0;

		// Token: 0x04007D58 RID: 32088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
