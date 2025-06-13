using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Cutscenes
{
	// Token: 0x020004A1 RID: 1185
	public class CutsceneManager : Singleton<CutsceneManager>
	{
		// Token: 0x060065BD RID: 26045 RVA: 0x001CEB40 File Offset: 0x001CCD40
		// Note: this type is marked as 'beforefieldinit'.
		static CutsceneManager()
		{
			Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cutscenes", "CutsceneManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr);
			CutsceneManager.NativeFieldInfoPtr_Cutscenes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, "Cutscenes");
			CutsceneManager.NativeFieldInfoPtr_cutsceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, "cutsceneName");
			CutsceneManager.NativeFieldInfoPtr_playingCutscene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, "playingCutscene");
			CutsceneManager.NativeMethodInfoPtr_RunCutscene_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, 100676284);
			CutsceneManager.NativeMethodInfoPtr_Play_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, 100676285);
			CutsceneManager.NativeMethodInfoPtr_Ended_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, 100676286);
			CutsceneManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, 100676287);
		}

		// Token: 0x060065BE RID: 26046 RVA: 0x001CEBFC File Offset: 0x001CCDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208308, XrefRangeEnd = 208334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunCutscene()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.NativeMethodInfoPtr_RunCutscene_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065BF RID: 26047 RVA: 0x001CEC30 File Offset: 0x001CCE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208334, XrefRangeEnd = 208360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.NativeMethodInfoPtr_Play_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065C0 RID: 26048 RVA: 0x001CEC74 File Offset: 0x001CCE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208360, XrefRangeEnd = 208369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Ended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.NativeMethodInfoPtr_Ended_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x001CECA8 File Offset: 0x001CCEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208369, XrefRangeEnd = 208376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutsceneManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x0002FDFD File Offset: 0x0002DFFD
		public CutsceneManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x060065C3 RID: 26051 RVA: 0x001CECE4 File Offset: 0x001CCEE4
		// (set) Token: 0x060065C4 RID: 26052 RVA: 0x0002FE06 File Offset: 0x0002E006
		public unsafe List<Cutscene> Cutscenes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_Cutscenes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Cutscene>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_Cutscenes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x060065C5 RID: 26053 RVA: 0x001CED14 File Offset: 0x001CCF14
		// (set) Token: 0x060065C6 RID: 26054 RVA: 0x0002FE25 File Offset: 0x0002E025
		public unsafe string cutsceneName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_cutsceneName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_cutsceneName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x060065C7 RID: 26055 RVA: 0x001CED3C File Offset: 0x001CCF3C
		// (set) Token: 0x060065C8 RID: 26056 RVA: 0x0002FE44 File Offset: 0x0002E044
		public unsafe Cutscene playingCutscene
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_playingCutscene);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cutscene>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.NativeFieldInfoPtr_playingCutscene), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004571 RID: 17777
		private static readonly System.IntPtr NativeFieldInfoPtr_Cutscenes;

		// Token: 0x04004572 RID: 17778
		private static readonly System.IntPtr NativeFieldInfoPtr_cutsceneName;

		// Token: 0x04004573 RID: 17779
		private static readonly System.IntPtr NativeFieldInfoPtr_playingCutscene;

		// Token: 0x04004574 RID: 17780
		private static readonly System.IntPtr NativeMethodInfoPtr_RunCutscene_Private_Void_0;

		// Token: 0x04004575 RID: 17781
		private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_String_0;

		// Token: 0x04004576 RID: 17782
		private static readonly System.IntPtr NativeMethodInfoPtr_Ended_Private_Void_0;

		// Token: 0x04004577 RID: 17783
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A76 RID: 2678
		[ObfuscatedName("ScheduleOne.Cutscenes.CutsceneManager+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D465 RID: 54373 RVA: 0x0033286C File Offset: 0x00330A6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CutsceneManager>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr);
				CutsceneManager.__c__DisplayClass4_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr, "name");
				CutsceneManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr, 100676288);
				CutsceneManager.__c__DisplayClass4_0.NativeMethodInfoPtr__Play_b__0_Internal_Boolean_Cutscene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr, 100676289);
			}

			// Token: 0x0600D466 RID: 54374 RVA: 0x003328D4 File Offset: 0x00330AD4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutsceneManager.__c__DisplayClass4_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D467 RID: 54375 RVA: 0x00332910 File Offset: 0x00330B10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208304, XrefRangeEnd = 208308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Play_b__0(Cutscene c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CutsceneManager.__c__DisplayClass4_0.NativeMethodInfoPtr__Play_b__0_Internal_Boolean_Cutscene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D468 RID: 54376 RVA: 0x0006700D File Offset: 0x0006520D
			public __c__DisplayClass4_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041B5 RID: 16821
			// (get) Token: 0x0600D469 RID: 54377 RVA: 0x00332960 File Offset: 0x00330B60
			// (set) Token: 0x0600D46A RID: 54378 RVA: 0x00067016 File Offset: 0x00065216
			public unsafe string name
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.__c__DisplayClass4_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CutsceneManager.__c__DisplayClass4_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008F5A RID: 36698
			private static readonly System.IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04008F5B RID: 36699
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F5C RID: 36700
			private static readonly System.IntPtr NativeMethodInfoPtr__Play_b__0_Internal_Boolean_Cutscene_0;
		}
	}
}
