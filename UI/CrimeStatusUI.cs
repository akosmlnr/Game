using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000679 RID: 1657
	public class CrimeStatusUI : MonoBehaviour
	{
		// Token: 0x060092E2 RID: 37602 RVA: 0x002628E4 File Offset: 0x00260AE4
		// Note: this type is marked as 'beforefieldinit'.
		static CrimeStatusUI()
		{
			Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CrimeStatusUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr);
			CrimeStatusUI.NativeFieldInfoPtr_SmallTextSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "SmallTextSize");
			CrimeStatusUI.NativeFieldInfoPtr_LargeTextSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "LargeTextSize");
			CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "CrimeStatusContainer");
			CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "CrimeStatusGroup");
			CrimeStatusUI.NativeFieldInfoPtr_BodysearchLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "BodysearchLabel");
			CrimeStatusUI.NativeFieldInfoPtr_InvestigatingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "InvestigatingMask");
			CrimeStatusUI.NativeFieldInfoPtr_UnderArrestMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "UnderArrestMask");
			CrimeStatusUI.NativeFieldInfoPtr_WantedMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "WantedMask");
			CrimeStatusUI.NativeFieldInfoPtr_WantedDeadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "WantedDeadMask");
			CrimeStatusUI.NativeFieldInfoPtr_ArrestProgressContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "ArrestProgressContainer");
			CrimeStatusUI.NativeFieldInfoPtr_animateText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "animateText");
			CrimeStatusUI.NativeFieldInfoPtr_routine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "routine");
			CrimeStatusUI.NativeMethodInfoPtr_UpdateStatus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, 100681591);
			CrimeStatusUI.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, 100681592);
			CrimeStatusUI.NativeMethodInfoPtr_Routine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, 100681593);
			CrimeStatusUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, 100681594);
		}

		// Token: 0x060092E3 RID: 37603 RVA: 0x00262A54 File Offset: 0x00260C54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265933, RefRangeEnd = 265935, XrefRangeStart = 265892, XrefRangeEnd = 265933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI.NativeMethodInfoPtr_UpdateStatus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060092E4 RID: 37604 RVA: 0x00262A88 File Offset: 0x00260C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265935, XrefRangeEnd = 265943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060092E5 RID: 37605 RVA: 0x00262ABC File Offset: 0x00260CBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265948, RefRangeEnd = 265950, XrefRangeStart = 265943, XrefRangeEnd = 265948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Routine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI.NativeMethodInfoPtr_Routine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060092E6 RID: 37606 RVA: 0x00262AFC File Offset: 0x00260CFC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrimeStatusUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060092E7 RID: 37607 RVA: 0x00046A6B File Offset: 0x00044C6B
		public CrimeStatusUI(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CC3 RID: 11459
		// (get) Token: 0x060092E8 RID: 37608 RVA: 0x00262B38 File Offset: 0x00260D38
		// (set) Token: 0x060092E9 RID: 37609 RVA: 0x00046A74 File Offset: 0x00044C74
		public unsafe static float SmallTextSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CrimeStatusUI.NativeFieldInfoPtr_SmallTextSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CrimeStatusUI.NativeFieldInfoPtr_SmallTextSize, (void*)(&value));
			}
		}

		// Token: 0x17002CC4 RID: 11460
		// (get) Token: 0x060092EA RID: 37610 RVA: 0x00262B54 File Offset: 0x00260D54
		// (set) Token: 0x060092EB RID: 37611 RVA: 0x00046A82 File Offset: 0x00044C82
		public unsafe static float LargeTextSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CrimeStatusUI.NativeFieldInfoPtr_LargeTextSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CrimeStatusUI.NativeFieldInfoPtr_LargeTextSize, (void*)(&value));
			}
		}

		// Token: 0x17002CC5 RID: 11461
		// (get) Token: 0x060092EC RID: 37612 RVA: 0x00262B70 File Offset: 0x00260D70
		// (set) Token: 0x060092ED RID: 37613 RVA: 0x00046A90 File Offset: 0x00044C90
		public unsafe RectTransform CrimeStatusContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CC6 RID: 11462
		// (get) Token: 0x060092EE RID: 37614 RVA: 0x00262BA0 File Offset: 0x00260DA0
		// (set) Token: 0x060092EF RID: 37615 RVA: 0x00046AAF File Offset: 0x00044CAF
		public unsafe CanvasGroup CrimeStatusGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusGroup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CC7 RID: 11463
		// (get) Token: 0x060092F0 RID: 37616 RVA: 0x00262BD0 File Offset: 0x00260DD0
		// (set) Token: 0x060092F1 RID: 37617 RVA: 0x00046ACE File Offset: 0x00044CCE
		public unsafe GameObject BodysearchLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_BodysearchLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_BodysearchLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CC8 RID: 11464
		// (get) Token: 0x060092F2 RID: 37618 RVA: 0x00262C00 File Offset: 0x00260E00
		// (set) Token: 0x060092F3 RID: 37619 RVA: 0x00046AED File Offset: 0x00044CED
		public unsafe Image InvestigatingMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_InvestigatingMask);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_InvestigatingMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CC9 RID: 11465
		// (get) Token: 0x060092F4 RID: 37620 RVA: 0x00262C30 File Offset: 0x00260E30
		// (set) Token: 0x060092F5 RID: 37621 RVA: 0x00046B0C File Offset: 0x00044D0C
		public unsafe Image UnderArrestMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_UnderArrestMask);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_UnderArrestMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CCA RID: 11466
		// (get) Token: 0x060092F6 RID: 37622 RVA: 0x00262C60 File Offset: 0x00260E60
		// (set) Token: 0x060092F7 RID: 37623 RVA: 0x00046B2B File Offset: 0x00044D2B
		public unsafe Image WantedMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_WantedMask);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_WantedMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CCB RID: 11467
		// (get) Token: 0x060092F8 RID: 37624 RVA: 0x00262C90 File Offset: 0x00260E90
		// (set) Token: 0x060092F9 RID: 37625 RVA: 0x00046B4A File Offset: 0x00044D4A
		public unsafe Image WantedDeadMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_WantedDeadMask);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_WantedDeadMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CCC RID: 11468
		// (get) Token: 0x060092FA RID: 37626 RVA: 0x00262CC0 File Offset: 0x00260EC0
		// (set) Token: 0x060092FB RID: 37627 RVA: 0x00046B69 File Offset: 0x00044D69
		public unsafe GameObject ArrestProgressContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_ArrestProgressContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_ArrestProgressContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CCD RID: 11469
		// (get) Token: 0x060092FC RID: 37628 RVA: 0x00262CF0 File Offset: 0x00260EF0
		// (set) Token: 0x060092FD RID: 37629 RVA: 0x00046B88 File Offset: 0x00044D88
		public unsafe bool animateText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_animateText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_animateText)) = value;
			}
		}

		// Token: 0x17002CCE RID: 11470
		// (get) Token: 0x060092FE RID: 37630 RVA: 0x00262D18 File Offset: 0x00260F18
		// (set) Token: 0x060092FF RID: 37631 RVA: 0x00046BA3 File Offset: 0x00044DA3
		public unsafe Coroutine routine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_routine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_routine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400635D RID: 25437
		private static readonly System.IntPtr NativeFieldInfoPtr_SmallTextSize;

		// Token: 0x0400635E RID: 25438
		private static readonly System.IntPtr NativeFieldInfoPtr_LargeTextSize;

		// Token: 0x0400635F RID: 25439
		private static readonly System.IntPtr NativeFieldInfoPtr_CrimeStatusContainer;

		// Token: 0x04006360 RID: 25440
		private static readonly System.IntPtr NativeFieldInfoPtr_CrimeStatusGroup;

		// Token: 0x04006361 RID: 25441
		private static readonly System.IntPtr NativeFieldInfoPtr_BodysearchLabel;

		// Token: 0x04006362 RID: 25442
		private static readonly System.IntPtr NativeFieldInfoPtr_InvestigatingMask;

		// Token: 0x04006363 RID: 25443
		private static readonly System.IntPtr NativeFieldInfoPtr_UnderArrestMask;

		// Token: 0x04006364 RID: 25444
		private static readonly System.IntPtr NativeFieldInfoPtr_WantedMask;

		// Token: 0x04006365 RID: 25445
		private static readonly System.IntPtr NativeFieldInfoPtr_WantedDeadMask;

		// Token: 0x04006366 RID: 25446
		private static readonly System.IntPtr NativeFieldInfoPtr_ArrestProgressContainer;

		// Token: 0x04006367 RID: 25447
		private static readonly System.IntPtr NativeFieldInfoPtr_animateText;

		// Token: 0x04006368 RID: 25448
		private static readonly System.IntPtr NativeFieldInfoPtr_routine;

		// Token: 0x04006369 RID: 25449
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateStatus_Public_Void_0;

		// Token: 0x0400636A RID: 25450
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400636B RID: 25451
		private static readonly System.IntPtr NativeMethodInfoPtr_Routine_Private_IEnumerator_0;

		// Token: 0x0400636C RID: 25452
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B8B RID: 2955
		[ObfuscatedName("ScheduleOne.UI.CrimeStatusUI+<Routine>d__14")]
		public sealed class _Routine_d__14 : Il2CppSystem.Object
		{
			// Token: 0x0600DDAB RID: 56747 RVA: 0x0034C774 File Offset: 0x0034A974
			// Note: this type is marked as 'beforefieldinit'.
			static _Routine_d__14()
			{
				Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "<Routine>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr);
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<>1__state");
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<>2__current");
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<>4__this");
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<lerpTime>5__2");
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__t_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<t>5__3");
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100681595);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100681596);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100681597);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100681598);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100681599);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100681600);
			}

			// Token: 0x0600DDAC RID: 56748 RVA: 0x0034C87C File Offset: 0x0034AA7C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Routine_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DDAD RID: 56749 RVA: 0x0034C8C4 File Offset: 0x0034AAC4
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DDAE RID: 56750 RVA: 0x0034C8F8 File Offset: 0x0034AAF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265870, XrefRangeEnd = 265887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004472 RID: 17522
			// (get) Token: 0x0600DDAF RID: 56751 RVA: 0x0034C934 File Offset: 0x0034AB34
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DDB0 RID: 56752 RVA: 0x0034C974 File Offset: 0x0034AB74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265887, XrefRangeEnd = 265892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004473 RID: 17523
			// (get) Token: 0x0600DDB1 RID: 56753 RVA: 0x0034C9A8 File Offset: 0x0034ABA8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DDB2 RID: 56754 RVA: 0x0006BA26 File Offset: 0x00069C26
			public _Routine_d__14(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700446D RID: 17517
			// (get) Token: 0x0600DDB3 RID: 56755 RVA: 0x0034C9E8 File Offset: 0x0034ABE8
			// (set) Token: 0x0600DDB4 RID: 56756 RVA: 0x0006BA2F File Offset: 0x00069C2F
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700446E RID: 17518
			// (get) Token: 0x0600DDB5 RID: 56757 RVA: 0x0034CA10 File Offset: 0x0034AC10
			// (set) Token: 0x0600DDB6 RID: 56758 RVA: 0x0006BA4A File Offset: 0x00069C4A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700446F RID: 17519
			// (get) Token: 0x0600DDB7 RID: 56759 RVA: 0x0034CA40 File Offset: 0x0034AC40
			// (set) Token: 0x0600DDB8 RID: 56760 RVA: 0x0006BA69 File Offset: 0x00069C69
			public unsafe CrimeStatusUI __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CrimeStatusUI>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004470 RID: 17520
			// (get) Token: 0x0600DDB9 RID: 56761 RVA: 0x0034CA70 File Offset: 0x0034AC70
			// (set) Token: 0x0600DDBA RID: 56762 RVA: 0x0006BA88 File Offset: 0x00069C88
			public unsafe float _lerpTime_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x17004471 RID: 17521
			// (get) Token: 0x0600DDBB RID: 56763 RVA: 0x0034CA98 File Offset: 0x0034AC98
			// (set) Token: 0x0600DDBC RID: 56764 RVA: 0x0006BAA3 File Offset: 0x00069CA3
			public unsafe float _t_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__t_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__t_5__3)) = value;
				}
			}

			// Token: 0x0400950B RID: 38155
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400950C RID: 38156
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400950D RID: 38157
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400950E RID: 38158
			private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x0400950F RID: 38159
			private static readonly System.IntPtr NativeFieldInfoPtr__t_5__3;

			// Token: 0x04009510 RID: 38160
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009511 RID: 38161
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009512 RID: 38162
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009513 RID: 38163
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009514 RID: 38164
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009515 RID: 38165
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
