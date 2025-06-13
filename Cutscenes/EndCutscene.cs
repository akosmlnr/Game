using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Cutscenes
{
	// Token: 0x020004A2 RID: 1186
	public class EndCutscene : Cutscene
	{
		// Token: 0x060065C9 RID: 26057 RVA: 0x001CED6C File Offset: 0x001CCF6C
		// Note: this type is marked as 'beforefieldinit'.
		static EndCutscene()
		{
			Il2CppClassPointerStore<EndCutscene>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cutscenes", "EndCutscene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr);
			EndCutscene.NativeFieldInfoPtr_onStandUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, "onStandUp");
			EndCutscene.NativeFieldInfoPtr_onRunStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, "onRunStart");
			EndCutscene.NativeFieldInfoPtr_onEngineStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, "onEngineStart");
			EndCutscene.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, "Avatar");
			EndCutscene.NativeMethodInfoPtr_Play_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100676290);
			EndCutscene.NativeMethodInfoPtr_StandUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100676291);
			EndCutscene.NativeMethodInfoPtr_RunStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100676292);
			EndCutscene.NativeMethodInfoPtr_EngineStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100676293);
			EndCutscene.NativeMethodInfoPtr_On3rdPerson_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100676294);
			EndCutscene.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr, 100676295);
		}

		// Token: 0x060065CA RID: 26058 RVA: 0x001CEE64 File Offset: 0x001CD064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208376, XrefRangeEnd = 208383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EndCutscene.NativeMethodInfoPtr_Play_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065CB RID: 26059 RVA: 0x001CEEA0 File Offset: 0x001CD0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208383, XrefRangeEnd = 208384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StandUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr_StandUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065CC RID: 26060 RVA: 0x001CEED4 File Offset: 0x001CD0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208384, XrefRangeEnd = 208385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr_RunStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065CD RID: 26061 RVA: 0x001CEF08 File Offset: 0x001CD108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208385, XrefRangeEnd = 208386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EngineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr_EngineStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065CE RID: 26062 RVA: 0x001CEF3C File Offset: 0x001CD13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208386, XrefRangeEnd = 208392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void On3rdPerson()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr_On3rdPerson_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065CF RID: 26063 RVA: 0x001CEF70 File Offset: 0x001CD170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndCutscene() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndCutscene>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndCutscene.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065D0 RID: 26064 RVA: 0x0002FE63 File Offset: 0x0002E063
		public EndCutscene(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x060065D1 RID: 26065 RVA: 0x001CEFAC File Offset: 0x001CD1AC
		// (set) Token: 0x060065D2 RID: 26066 RVA: 0x0002FE6C File Offset: 0x0002E06C
		public unsafe UnityEvent onStandUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onStandUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onStandUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x060065D3 RID: 26067 RVA: 0x001CEFDC File Offset: 0x001CD1DC
		// (set) Token: 0x060065D4 RID: 26068 RVA: 0x0002FE8B File Offset: 0x0002E08B
		public unsafe UnityEvent onRunStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onRunStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onRunStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x060065D5 RID: 26069 RVA: 0x001CF00C File Offset: 0x001CD20C
		// (set) Token: 0x060065D6 RID: 26070 RVA: 0x0002FEAA File Offset: 0x0002E0AA
		public unsafe UnityEvent onEngineStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onEngineStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_onEngineStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x060065D7 RID: 26071 RVA: 0x001CF03C File Offset: 0x001CD23C
		// (set) Token: 0x060065D8 RID: 26072 RVA: 0x0002FEC9 File Offset: 0x0002E0C9
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndCutscene.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004578 RID: 17784
		private static readonly IntPtr NativeFieldInfoPtr_onStandUp;

		// Token: 0x04004579 RID: 17785
		private static readonly IntPtr NativeFieldInfoPtr_onRunStart;

		// Token: 0x0400457A RID: 17786
		private static readonly IntPtr NativeFieldInfoPtr_onEngineStart;

		// Token: 0x0400457B RID: 17787
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x0400457C RID: 17788
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Void_0;

		// Token: 0x0400457D RID: 17789
		private static readonly IntPtr NativeMethodInfoPtr_StandUp_Public_Void_0;

		// Token: 0x0400457E RID: 17790
		private static readonly IntPtr NativeMethodInfoPtr_RunStart_Public_Void_0;

		// Token: 0x0400457F RID: 17791
		private static readonly IntPtr NativeMethodInfoPtr_EngineStart_Public_Void_0;

		// Token: 0x04004580 RID: 17792
		private static readonly IntPtr NativeMethodInfoPtr_On3rdPerson_Public_Void_0;

		// Token: 0x04004581 RID: 17793
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
