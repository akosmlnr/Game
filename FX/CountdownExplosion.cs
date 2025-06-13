using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x02000416 RID: 1046
	public class CountdownExplosion : MonoBehaviour
	{
		// Token: 0x060055C0 RID: 21952 RVA: 0x0019420C File Offset: 0x0019240C
		// Note: this type is marked as 'beforefieldinit'.
		static CountdownExplosion()
		{
			Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "CountdownExplosion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr);
			CountdownExplosion.NativeFieldInfoPtr_COUNTDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "COUNTDOWN");
			CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "TICK_SPACING_MAX");
			CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "TICK_SPACING_MIN");
			CountdownExplosion.NativeFieldInfoPtr_TickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "TickSound");
			CountdownExplosion.NativeFieldInfoPtr_countdownRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "countdownRoutine");
			CountdownExplosion.NativeMethodInfoPtr_Trigger_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, 100674068);
			CountdownExplosion.NativeMethodInfoPtr_StopCountdown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, 100674069);
			CountdownExplosion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, 100674070);
			CountdownExplosion.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, 100674071);
		}

		// Token: 0x060055C1 RID: 21953 RVA: 0x001942F0 File Offset: 0x001924F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184147, RefRangeEnd = 184148, XrefRangeStart = 184135, XrefRangeEnd = 184147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.NativeMethodInfoPtr_Trigger_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060055C2 RID: 21954 RVA: 0x00194324 File Offset: 0x00192524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19028, RefRangeEnd = 19029, XrefRangeStart = 19028, XrefRangeEnd = 19029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCountdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.NativeMethodInfoPtr_StopCountdown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060055C3 RID: 21955 RVA: 0x00194358 File Offset: 0x00192558
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CountdownExplosion() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060055C4 RID: 21956 RVA: 0x00194394 File Offset: 0x00192594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184148, XrefRangeEnd = 184153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060055C5 RID: 21957 RVA: 0x00028D40 File Offset: 0x00026F40
		public CountdownExplosion(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x060055C6 RID: 21958 RVA: 0x001943D4 File Offset: 0x001925D4
		// (set) Token: 0x060055C7 RID: 21959 RVA: 0x00028D49 File Offset: 0x00026F49
		public unsafe static float COUNTDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CountdownExplosion.NativeFieldInfoPtr_COUNTDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CountdownExplosion.NativeFieldInfoPtr_COUNTDOWN, (void*)(&value));
			}
		}

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x060055C8 RID: 21960 RVA: 0x001943F0 File Offset: 0x001925F0
		// (set) Token: 0x060055C9 RID: 21961 RVA: 0x00028D57 File Offset: 0x00026F57
		public unsafe static float TICK_SPACING_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MAX, (void*)(&value));
			}
		}

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x060055CA RID: 21962 RVA: 0x0019440C File Offset: 0x0019260C
		// (set) Token: 0x060055CB RID: 21963 RVA: 0x00028D65 File Offset: 0x00026F65
		public unsafe static float TICK_SPACING_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MIN, (void*)(&value));
			}
		}

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x060055CC RID: 21964 RVA: 0x00194428 File Offset: 0x00192628
		// (set) Token: 0x060055CD RID: 21965 RVA: 0x00028D73 File Offset: 0x00026F73
		public unsafe AudioSourceController TickSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.NativeFieldInfoPtr_TickSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.NativeFieldInfoPtr_TickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x060055CE RID: 21966 RVA: 0x00194458 File Offset: 0x00192658
		// (set) Token: 0x060055CF RID: 21967 RVA: 0x00028D92 File Offset: 0x00026F92
		public unsafe Coroutine countdownRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.NativeFieldInfoPtr_countdownRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.NativeFieldInfoPtr_countdownRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A15 RID: 14869
		private static readonly System.IntPtr NativeFieldInfoPtr_COUNTDOWN;

		// Token: 0x04003A16 RID: 14870
		private static readonly System.IntPtr NativeFieldInfoPtr_TICK_SPACING_MAX;

		// Token: 0x04003A17 RID: 14871
		private static readonly System.IntPtr NativeFieldInfoPtr_TICK_SPACING_MIN;

		// Token: 0x04003A18 RID: 14872
		private static readonly System.IntPtr NativeFieldInfoPtr_TickSound;

		// Token: 0x04003A19 RID: 14873
		private static readonly System.IntPtr NativeFieldInfoPtr_countdownRoutine;

		// Token: 0x04003A1A RID: 14874
		private static readonly System.IntPtr NativeMethodInfoPtr_Trigger_Public_Void_0;

		// Token: 0x04003A1B RID: 14875
		private static readonly System.IntPtr NativeMethodInfoPtr_StopCountdown_Public_Void_0;

		// Token: 0x04003A1C RID: 14876
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003A1D RID: 14877
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000A02 RID: 2562
		[ObfuscatedName("ScheduleOne.FX.CountdownExplosion+<<Trigger>g__Routine|5_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D106 RID: 53510 RVA: 0x00328ED0 File Offset: 0x003270D0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique()
			{
				Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "<<Trigger>g__Routine|5_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<>1__state");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<>2__current");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<>4__this");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__timeUntilNextTick_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<timeUntilNextTick>5__2");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100674072);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100674073);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100674074);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100674075);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100674076);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100674077);
			}

			// Token: 0x0600D107 RID: 53511 RVA: 0x00328FD8 File Offset: 0x003271D8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D108 RID: 53512 RVA: 0x00329020 File Offset: 0x00327220
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D109 RID: 53513 RVA: 0x00329054 File Offset: 0x00327254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184117, XrefRangeEnd = 184130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170040D2 RID: 16594
			// (get) Token: 0x0600D10A RID: 53514 RVA: 0x00329090 File Offset: 0x00327290
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D10B RID: 53515 RVA: 0x003290D0 File Offset: 0x003272D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184130, XrefRangeEnd = 184135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170040D3 RID: 16595
			// (get) Token: 0x0600D10C RID: 53516 RVA: 0x00329104 File Offset: 0x00327304
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D10D RID: 53517 RVA: 0x000655D2 File Offset: 0x000637D2
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040CD RID: 16589
			// (get) Token: 0x0600D10E RID: 53518 RVA: 0x00329144 File Offset: 0x00327344
			// (set) Token: 0x0600D10F RID: 53519 RVA: 0x000655DB File Offset: 0x000637DB
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170040CE RID: 16590
			// (get) Token: 0x0600D110 RID: 53520 RVA: 0x0032916C File Offset: 0x0032736C
			// (set) Token: 0x0600D111 RID: 53521 RVA: 0x000655F6 File Offset: 0x000637F6
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040CF RID: 16591
			// (get) Token: 0x0600D112 RID: 53522 RVA: 0x0032919C File Offset: 0x0032739C
			// (set) Token: 0x0600D113 RID: 53523 RVA: 0x00065615 File Offset: 0x00063815
			public unsafe CountdownExplosion __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CountdownExplosion>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040D0 RID: 16592
			// (get) Token: 0x0600D114 RID: 53524 RVA: 0x003291CC File Offset: 0x003273CC
			// (set) Token: 0x0600D115 RID: 53525 RVA: 0x00065634 File Offset: 0x00063834
			public unsafe float _timeUntilNextTick_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__timeUntilNextTick_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__timeUntilNextTick_5__2)) = value;
				}
			}

			// Token: 0x170040D1 RID: 16593
			// (get) Token: 0x0600D116 RID: 53526 RVA: 0x003291F4 File Offset: 0x003273F4
			// (set) Token: 0x0600D117 RID: 53527 RVA: 0x0006564F File Offset: 0x0006384F
			public unsafe float _i_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04008D5C RID: 36188
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D5D RID: 36189
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D5E RID: 36190
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D5F RID: 36191
			private static readonly System.IntPtr NativeFieldInfoPtr__timeUntilNextTick_5__2;

			// Token: 0x04008D60 RID: 36192
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04008D61 RID: 36193
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D62 RID: 36194
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D63 RID: 36195
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D64 RID: 36196
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D65 RID: 36197
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D66 RID: 36198
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
