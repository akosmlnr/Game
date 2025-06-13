using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.VoiceOver
{
	// Token: 0x02000179 RID: 377
	public class PoliceChatterVO : VOEmitter
	{
		// Token: 0x06001DF3 RID: 7667 RVA: 0x000D0924 File Offset: 0x000CEB24
		// Note: this type is marked as 'beforefieldinit'.
		static PoliceChatterVO()
		{
			Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.VoiceOver", "PoliceChatterVO");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr);
			PoliceChatterVO.NativeFieldInfoPtr_StartBeep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, "StartBeep");
			PoliceChatterVO.NativeFieldInfoPtr_StartEndBeep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, "StartEndBeep");
			PoliceChatterVO.NativeFieldInfoPtr_Static = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, "Static");
			PoliceChatterVO.NativeFieldInfoPtr_chatterRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, "chatterRoutine");
			PoliceChatterVO.NativeMethodInfoPtr_Play_Public_Virtual_Void_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, 100666739);
			PoliceChatterVO.NativeMethodInfoPtr_PlayChatter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, 100666740);
			PoliceChatterVO.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, 100666741);
			PoliceChatterVO.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, 100666742);
			PoliceChatterVO.NativeMethodInfoPtr__PlayChatter_b__5_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, 100666743);
			PoliceChatterVO.NativeMethodInfoPtr___n__0_Private_Void_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, 100666744);
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x000D0A1C File Offset: 0x000CEC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109728, XrefRangeEnd = 109737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Play(EVOLineType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref lineType;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceChatterVO.NativeMethodInfoPtr_Play_Public_Virtual_Void_EVOLineType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x000D0A68 File Offset: 0x000CEC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109737, XrefRangeEnd = 109745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayChatter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.NativeMethodInfoPtr_PlayChatter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x000D0A9C File Offset: 0x000CEC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109745, XrefRangeEnd = 109746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceChatterVO() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x000D0AD8 File Offset: 0x000CECD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109746, XrefRangeEnd = 109751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x000D0B18 File Offset: 0x000CED18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109751, XrefRangeEnd = 109752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PlayChatter_b__5_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.NativeMethodInfoPtr__PlayChatter_b__5_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x000D0B54 File Offset: 0x000CED54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109752, XrefRangeEnd = 109753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __n__0(EVOLineType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref lineType;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.NativeMethodInfoPtr___n__0_Private_Void_EVOLineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00010CF1 File Offset: 0x0000EEF1
		public PoliceChatterVO(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x000D0B94 File Offset: 0x000CED94
		// (set) Token: 0x06001DFC RID: 7676 RVA: 0x00010CFA File Offset: 0x0000EEFA
		public unsafe AudioSourceController StartBeep
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.NativeFieldInfoPtr_StartBeep);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.NativeFieldInfoPtr_StartBeep), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x000D0BC4 File Offset: 0x000CEDC4
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x00010D19 File Offset: 0x0000EF19
		public unsafe AudioSourceController StartEndBeep
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.NativeFieldInfoPtr_StartEndBeep);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.NativeFieldInfoPtr_StartEndBeep), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x000D0BF4 File Offset: 0x000CEDF4
		// (set) Token: 0x06001E00 RID: 7680 RVA: 0x00010D38 File Offset: 0x0000EF38
		public unsafe AudioSourceController Static
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.NativeFieldInfoPtr_Static);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.NativeFieldInfoPtr_Static), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x000D0C24 File Offset: 0x000CEE24
		// (set) Token: 0x06001E02 RID: 7682 RVA: 0x00010D57 File Offset: 0x0000EF57
		public unsafe Coroutine chatterRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.NativeFieldInfoPtr_chatterRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.NativeFieldInfoPtr_chatterRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013F2 RID: 5106
		private static readonly System.IntPtr NativeFieldInfoPtr_StartBeep;

		// Token: 0x040013F3 RID: 5107
		private static readonly System.IntPtr NativeFieldInfoPtr_StartEndBeep;

		// Token: 0x040013F4 RID: 5108
		private static readonly System.IntPtr NativeFieldInfoPtr_Static;

		// Token: 0x040013F5 RID: 5109
		private static readonly System.IntPtr NativeFieldInfoPtr_chatterRoutine;

		// Token: 0x040013F6 RID: 5110
		private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Void_EVOLineType_0;

		// Token: 0x040013F7 RID: 5111
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayChatter_Private_Void_0;

		// Token: 0x040013F8 RID: 5112
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040013F9 RID: 5113
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040013FA RID: 5114
		private static readonly System.IntPtr NativeMethodInfoPtr__PlayChatter_b__5_1_Private_Boolean_0;

		// Token: 0x040013FB RID: 5115
		private static readonly System.IntPtr NativeMethodInfoPtr___n__0_Private_Void_EVOLineType_0;

		// Token: 0x020008D8 RID: 2264
		[ObfuscatedName("ScheduleOne.VoiceOver.PoliceChatterVO+<<PlayChatter>g__Play|5_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C731 RID: 50993 RVA: 0x0030C9C0 File Offset: 0x0030ABC0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique()
			{
				Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoliceChatterVO>.NativeClassPtr, "<<PlayChatter>g__Play|5_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr);
				PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, "<>1__state");
				PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, "<>2__current");
				PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, "<>4__this");
				PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100666745);
				PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100666746);
				PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100666747);
				PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100666748);
				PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100666749);
				PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100666750);
			}

			// Token: 0x0600C732 RID: 50994 RVA: 0x0030CAA0 File Offset: 0x0030ACA0
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C733 RID: 50995 RVA: 0x0030CAE8 File Offset: 0x0030ACE8
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C734 RID: 50996 RVA: 0x0030CB1C File Offset: 0x0030AD1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109717, XrefRangeEnd = 109723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003DEA RID: 15850
			// (get) Token: 0x0600C735 RID: 50997 RVA: 0x0030CB58 File Offset: 0x0030AD58
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C736 RID: 50998 RVA: 0x0030CB98 File Offset: 0x0030AD98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109723, XrefRangeEnd = 109728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003DEB RID: 15851
			// (get) Token: 0x0600C737 RID: 50999 RVA: 0x0030CBCC File Offset: 0x0030ADCC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C738 RID: 51000 RVA: 0x00060904 File Offset: 0x0005EB04
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DE7 RID: 15847
			// (get) Token: 0x0600C739 RID: 51001 RVA: 0x0030CC0C File Offset: 0x0030AE0C
			// (set) Token: 0x0600C73A RID: 51002 RVA: 0x0006090D File Offset: 0x0005EB0D
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003DE8 RID: 15848
			// (get) Token: 0x0600C73B RID: 51003 RVA: 0x0030CC34 File Offset: 0x0030AE34
			// (set) Token: 0x0600C73C RID: 51004 RVA: 0x00060928 File Offset: 0x0005EB28
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DE9 RID: 15849
			// (get) Token: 0x0600C73D RID: 51005 RVA: 0x0030CC64 File Offset: 0x0030AE64
			// (set) Token: 0x0600C73E RID: 51006 RVA: 0x00060947 File Offset: 0x0005EB47
			public unsafe PoliceChatterVO __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceChatterVO>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceChatterVO.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008720 RID: 34592
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008721 RID: 34593
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008722 RID: 34594
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008723 RID: 34595
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008724 RID: 34596
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008725 RID: 34597
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008726 RID: 34598
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008727 RID: 34599
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008728 RID: 34600
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
