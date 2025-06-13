using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Variables;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001D6 RID: 470
	[System.Serializable]
	public class SystemTrigger : Il2CppSystem.Object
	{
		// Token: 0x06002788 RID: 10120 RVA: 0x000EF5CC File Offset: 0x000ED7CC
		// Note: this type is marked as 'beforefieldinit'.
		static SystemTrigger()
		{
			Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "SystemTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr);
			SystemTrigger.NativeFieldInfoPtr_Conditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "Conditions");
			SystemTrigger.NativeFieldInfoPtr_onEvaluateTrueVariableSetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "onEvaluateTrueVariableSetters");
			SystemTrigger.NativeFieldInfoPtr_onEvaluateTrueQuestSetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "onEvaluateTrueQuestSetters");
			SystemTrigger.NativeFieldInfoPtr_onEvaluateTrue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "onEvaluateTrue");
			SystemTrigger.NativeFieldInfoPtr_onEvaluateFalseVariableSetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "onEvaluateFalseVariableSetters");
			SystemTrigger.NativeFieldInfoPtr_onEvaluateFalseQuestSetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "onEvaluateFalseQuestSetters");
			SystemTrigger.NativeFieldInfoPtr_onEvaluateFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "onEvaluateFalse");
			SystemTrigger.NativeMethodInfoPtr_Trigger_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, 100667748);
			SystemTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, 100667749);
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x000EF6B0 File Offset: 0x000ED8B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 121037, RefRangeEnd = 121041, XrefRangeStart = 121031, XrefRangeEnd = 121037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Trigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SystemTrigger.NativeMethodInfoPtr_Trigger_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x000EF6EC File Offset: 0x000ED8EC
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemTrigger() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x00015C7B File Offset: 0x00013E7B
		public SystemTrigger(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x0600278C RID: 10124 RVA: 0x000EF728 File Offset: 0x000ED928
		// (set) Token: 0x0600278D RID: 10125 RVA: 0x00015C84 File Offset: 0x00013E84
		public unsafe Conditions Conditions
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_Conditions);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Conditions>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_Conditions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x0600278E RID: 10126 RVA: 0x000EF758 File Offset: 0x000ED958
		// (set) Token: 0x0600278F RID: 10127 RVA: 0x00015CA3 File Offset: 0x00013EA3
		public unsafe Il2CppReferenceArray<VariableSetter> onEvaluateTrueVariableSetters
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateTrueVariableSetters);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VariableSetter>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateTrueVariableSetters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06002790 RID: 10128 RVA: 0x000EF788 File Offset: 0x000ED988
		// (set) Token: 0x06002791 RID: 10129 RVA: 0x00015CC2 File Offset: 0x00013EC2
		public unsafe Il2CppReferenceArray<QuestStateSetter> onEvaluateTrueQuestSetters
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateTrueQuestSetters);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestStateSetter>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateTrueQuestSetters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06002792 RID: 10130 RVA: 0x000EF7B8 File Offset: 0x000ED9B8
		// (set) Token: 0x06002793 RID: 10131 RVA: 0x00015CE1 File Offset: 0x00013EE1
		public unsafe UnityEvent onEvaluateTrue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateTrue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateTrue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06002794 RID: 10132 RVA: 0x000EF7E8 File Offset: 0x000ED9E8
		// (set) Token: 0x06002795 RID: 10133 RVA: 0x00015D00 File Offset: 0x00013F00
		public unsafe Il2CppReferenceArray<VariableSetter> onEvaluateFalseVariableSetters
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateFalseVariableSetters);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VariableSetter>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateFalseVariableSetters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06002796 RID: 10134 RVA: 0x000EF818 File Offset: 0x000EDA18
		// (set) Token: 0x06002797 RID: 10135 RVA: 0x00015D1F File Offset: 0x00013F1F
		public unsafe Il2CppReferenceArray<QuestStateSetter> onEvaluateFalseQuestSetters
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateFalseQuestSetters);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestStateSetter>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateFalseQuestSetters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06002798 RID: 10136 RVA: 0x000EF848 File Offset: 0x000EDA48
		// (set) Token: 0x06002799 RID: 10137 RVA: 0x00015D3E File Offset: 0x00013F3E
		public unsafe UnityEvent onEvaluateFalse
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateFalse);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateFalse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A43 RID: 6723
		private static readonly System.IntPtr NativeFieldInfoPtr_Conditions;

		// Token: 0x04001A44 RID: 6724
		private static readonly System.IntPtr NativeFieldInfoPtr_onEvaluateTrueVariableSetters;

		// Token: 0x04001A45 RID: 6725
		private static readonly System.IntPtr NativeFieldInfoPtr_onEvaluateTrueQuestSetters;

		// Token: 0x04001A46 RID: 6726
		private static readonly System.IntPtr NativeFieldInfoPtr_onEvaluateTrue;

		// Token: 0x04001A47 RID: 6727
		private static readonly System.IntPtr NativeFieldInfoPtr_onEvaluateFalseVariableSetters;

		// Token: 0x04001A48 RID: 6728
		private static readonly System.IntPtr NativeFieldInfoPtr_onEvaluateFalseQuestSetters;

		// Token: 0x04001A49 RID: 6729
		private static readonly System.IntPtr NativeFieldInfoPtr_onEvaluateFalse;

		// Token: 0x04001A4A RID: 6730
		private static readonly System.IntPtr NativeMethodInfoPtr_Trigger_Public_Boolean_0;

		// Token: 0x04001A4B RID: 6731
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
