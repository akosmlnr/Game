using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000581 RID: 1409
	public class SoilChunk : Clickable
	{
		// Token: 0x06007ACD RID: 31437 RVA: 0x0021489C File Offset: 0x00212A9C
		// Note: this type is marked as 'beforefieldinit'.
		static SoilChunk()
		{
			Il2CppClassPointerStore<SoilChunk>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "SoilChunk");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr);
			SoilChunk.NativeFieldInfoPtr__CurrentLerp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "<CurrentLerp>k__BackingField");
			SoilChunk.NativeFieldInfoPtr_EndTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "EndTransform");
			SoilChunk.NativeFieldInfoPtr_LerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "LerpTime");
			SoilChunk.NativeFieldInfoPtr_localPos_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "localPos_Start");
			SoilChunk.NativeFieldInfoPtr_localEulerAngles_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "localEulerAngles_Start");
			SoilChunk.NativeFieldInfoPtr_localScale_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "localScale_Start");
			SoilChunk.NativeFieldInfoPtr_lerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "lerpRoutine");
			SoilChunk.NativeMethodInfoPtr_get_CurrentLerp_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678788);
			SoilChunk.NativeMethodInfoPtr_set_CurrentLerp_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678789);
			SoilChunk.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678790);
			SoilChunk.NativeMethodInfoPtr_SetLerpedTransform_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678791);
			SoilChunk.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678792);
			SoilChunk.NativeMethodInfoPtr_StopLerp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678793);
			SoilChunk.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678794);
			SoilChunk.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, 100678795);
		}

		// Token: 0x170024F7 RID: 9463
		// (get) Token: 0x06007ACE RID: 31438 RVA: 0x002149F8 File Offset: 0x00212BF8
		// (set) Token: 0x06007ACF RID: 31439 RVA: 0x00214A34 File Offset: 0x00212C34
		public unsafe float CurrentLerp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_get_CurrentLerp_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_set_CurrentLerp_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007AD0 RID: 31440 RVA: 0x00214A74 File Offset: 0x00212C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236403, XrefRangeEnd = 236409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilChunk.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AD1 RID: 31441 RVA: 0x00214AB0 File Offset: 0x00212CB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236424, RefRangeEnd = 236425, XrefRangeStart = 236409, XrefRangeEnd = 236424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLerpedTransform(float _lerp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _lerp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_SetLerpedTransform_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AD2 RID: 31442 RVA: 0x00214AF0 File Offset: 0x00212CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236425, XrefRangeEnd = 236434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref hit;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilChunk.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AD3 RID: 31443 RVA: 0x00214B3C File Offset: 0x00212D3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236435, RefRangeEnd = 236436, XrefRangeStart = 236434, XrefRangeEnd = 236435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopLerp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_StopLerp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AD4 RID: 31444 RVA: 0x00214B70 File Offset: 0x00212D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236436, XrefRangeEnd = 236437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoilChunk() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AD5 RID: 31445 RVA: 0x00214BAC File Offset: 0x00212DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236437, XrefRangeEnd = 236442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06007AD6 RID: 31446 RVA: 0x0003A0AB File Offset: 0x000382AB
		public SoilChunk(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024F0 RID: 9456
		// (get) Token: 0x06007AD7 RID: 31447 RVA: 0x00214BEC File Offset: 0x00212DEC
		// (set) Token: 0x06007AD8 RID: 31448 RVA: 0x0003A0B4 File Offset: 0x000382B4
		public unsafe float _CurrentLerp_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr__CurrentLerp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr__CurrentLerp_k__BackingField)) = value;
			}
		}

		// Token: 0x170024F1 RID: 9457
		// (get) Token: 0x06007AD9 RID: 31449 RVA: 0x00214C14 File Offset: 0x00212E14
		// (set) Token: 0x06007ADA RID: 31450 RVA: 0x0003A0CF File Offset: 0x000382CF
		public unsafe Transform EndTransform
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_EndTransform);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_EndTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024F2 RID: 9458
		// (get) Token: 0x06007ADB RID: 31451 RVA: 0x00214C44 File Offset: 0x00212E44
		// (set) Token: 0x06007ADC RID: 31452 RVA: 0x0003A0EE File Offset: 0x000382EE
		public unsafe float LerpTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_LerpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_LerpTime)) = value;
			}
		}

		// Token: 0x170024F3 RID: 9459
		// (get) Token: 0x06007ADD RID: 31453 RVA: 0x00214C6C File Offset: 0x00212E6C
		// (set) Token: 0x06007ADE RID: 31454 RVA: 0x0003A109 File Offset: 0x00038309
		public unsafe Vector3 localPos_Start
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localPos_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localPos_Start)) = value;
			}
		}

		// Token: 0x170024F4 RID: 9460
		// (get) Token: 0x06007ADF RID: 31455 RVA: 0x00214C94 File Offset: 0x00212E94
		// (set) Token: 0x06007AE0 RID: 31456 RVA: 0x0003A124 File Offset: 0x00038324
		public unsafe Vector3 localEulerAngles_Start
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localEulerAngles_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localEulerAngles_Start)) = value;
			}
		}

		// Token: 0x170024F5 RID: 9461
		// (get) Token: 0x06007AE1 RID: 31457 RVA: 0x00214CBC File Offset: 0x00212EBC
		// (set) Token: 0x06007AE2 RID: 31458 RVA: 0x0003A13F File Offset: 0x0003833F
		public unsafe Vector3 localScale_Start
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localScale_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_localScale_Start)) = value;
			}
		}

		// Token: 0x170024F6 RID: 9462
		// (get) Token: 0x06007AE3 RID: 31459 RVA: 0x00214CE4 File Offset: 0x00212EE4
		// (set) Token: 0x06007AE4 RID: 31460 RVA: 0x0003A15A File Offset: 0x0003835A
		public unsafe Coroutine lerpRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_lerpRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.NativeFieldInfoPtr_lerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040053A7 RID: 21415
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentLerp_k__BackingField;

		// Token: 0x040053A8 RID: 21416
		private static readonly System.IntPtr NativeFieldInfoPtr_EndTransform;

		// Token: 0x040053A9 RID: 21417
		private static readonly System.IntPtr NativeFieldInfoPtr_LerpTime;

		// Token: 0x040053AA RID: 21418
		private static readonly System.IntPtr NativeFieldInfoPtr_localPos_Start;

		// Token: 0x040053AB RID: 21419
		private static readonly System.IntPtr NativeFieldInfoPtr_localEulerAngles_Start;

		// Token: 0x040053AC RID: 21420
		private static readonly System.IntPtr NativeFieldInfoPtr_localScale_Start;

		// Token: 0x040053AD RID: 21421
		private static readonly System.IntPtr NativeFieldInfoPtr_lerpRoutine;

		// Token: 0x040053AE RID: 21422
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentLerp_Public_get_Single_0;

		// Token: 0x040053AF RID: 21423
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentLerp_Protected_set_Void_Single_0;

		// Token: 0x040053B0 RID: 21424
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040053B1 RID: 21425
		private static readonly System.IntPtr NativeMethodInfoPtr_SetLerpedTransform_Public_Void_Single_0;

		// Token: 0x040053B2 RID: 21426
		private static readonly System.IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0;

		// Token: 0x040053B3 RID: 21427
		private static readonly System.IntPtr NativeMethodInfoPtr_StopLerp_Public_Void_0;

		// Token: 0x040053B4 RID: 21428
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040053B5 RID: 21429
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000AF4 RID: 2804
		[ObfuscatedName("ScheduleOne.Growing.SoilChunk+<<StartClick>g__Lerp|12_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D85C RID: 55388 RVA: 0x0033D694 File Offset: 0x0033B894
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique()
			{
				Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SoilChunk>.NativeClassPtr, "<<StartClick>g__Lerp|12_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, "<>1__state");
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, "<>2__current");
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, "<>4__this");
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, "<i>5__2");
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678796);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678797);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678798);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678799);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678800);
				SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr, 100678801);
			}

			// Token: 0x0600D85D RID: 55389 RVA: 0x0033D788 File Offset: 0x0033B988
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D85E RID: 55390 RVA: 0x0033D7D0 File Offset: 0x0033B9D0
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D85F RID: 55391 RVA: 0x0033D804 File Offset: 0x0033BA04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236389, XrefRangeEnd = 236398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170042CD RID: 17101
			// (get) Token: 0x0600D860 RID: 55392 RVA: 0x0033D840 File Offset: 0x0033BA40
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D861 RID: 55393 RVA: 0x0033D880 File Offset: 0x0033BA80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236398, XrefRangeEnd = 236403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170042CE RID: 17102
			// (get) Token: 0x0600D862 RID: 55394 RVA: 0x0033D8B4 File Offset: 0x0033BAB4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D863 RID: 55395 RVA: 0x00068FD7 File Offset: 0x000671D7
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042C9 RID: 17097
			// (get) Token: 0x0600D864 RID: 55396 RVA: 0x0033D8F4 File Offset: 0x0033BAF4
			// (set) Token: 0x0600D865 RID: 55397 RVA: 0x00068FE0 File Offset: 0x000671E0
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042CA RID: 17098
			// (get) Token: 0x0600D866 RID: 55398 RVA: 0x0033D91C File Offset: 0x0033BB1C
			// (set) Token: 0x0600D867 RID: 55399 RVA: 0x00068FFB File Offset: 0x000671FB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042CB RID: 17099
			// (get) Token: 0x0600D868 RID: 55400 RVA: 0x0033D94C File Offset: 0x0033BB4C
			// (set) Token: 0x0600D869 RID: 55401 RVA: 0x0006901A File Offset: 0x0006721A
			public unsafe SoilChunk __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SoilChunk>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042CC RID: 17100
			// (get) Token: 0x0600D86A RID: 55402 RVA: 0x0033D97C File Offset: 0x0033BB7C
			// (set) Token: 0x0600D86B RID: 55403 RVA: 0x00069039 File Offset: 0x00067239
			public unsafe float _i_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SoilChunk.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040091D7 RID: 37335
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040091D8 RID: 37336
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040091D9 RID: 37337
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091DA RID: 37338
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040091DB RID: 37339
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040091DC RID: 37340
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040091DD RID: 37341
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040091DE RID: 37342
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040091DF RID: 37343
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040091E0 RID: 37344
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
