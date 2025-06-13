using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000573 RID: 1395
	public class SmoothedVelocityCalculator : MonoBehaviour
	{
		// Token: 0x060079F7 RID: 31223 RVA: 0x00212418 File Offset: 0x00210618
		// Note: this type is marked as 'beforefieldinit'.
		static SmoothedVelocityCalculator()
		{
			Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SmoothedVelocityCalculator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr);
			SmoothedVelocityCalculator.NativeFieldInfoPtr_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "Velocity");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_SampleLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "SampleLength");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_MaxReasonableVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "MaxReasonableVelocity");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_VelocityHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "VelocityHistory");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_maxSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "maxSamples");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "lastFramePosition");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_zeroOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "zeroOut");
			SmoothedVelocityCalculator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678728);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678729);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_GetAverageVelocity_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678730);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_FlushBuffer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678731);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_ZeroOut_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678732);
			SmoothedVelocityCalculator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678733);
		}

		// Token: 0x060079F8 RID: 31224 RVA: 0x0021254C File Offset: 0x0021074C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235960, XrefRangeEnd = 235962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079F9 RID: 31225 RVA: 0x00212580 File Offset: 0x00210780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235985, RefRangeEnd = 235986, XrefRangeStart = 235962, XrefRangeEnd = 235985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmoothedVelocityCalculator.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079FA RID: 31226 RVA: 0x002125BC File Offset: 0x002107BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235997, RefRangeEnd = 235998, XrefRangeStart = 235986, XrefRangeEnd = 235997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetAverageVelocity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_GetAverageVelocity_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060079FB RID: 31227 RVA: 0x002125F8 File Offset: 0x002107F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 236004, RefRangeEnd = 236007, XrefRangeStart = 235998, XrefRangeEnd = 236004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_FlushBuffer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079FC RID: 31228 RVA: 0x0021262C File Offset: 0x0021082C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236007, XrefRangeEnd = 236019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ZeroOut(float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref duration;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_ZeroOut_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079FD RID: 31229 RVA: 0x0021266C File Offset: 0x0021086C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmoothedVelocityCalculator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079FE RID: 31230 RVA: 0x0003989D File Offset: 0x00037A9D
		public SmoothedVelocityCalculator(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024A8 RID: 9384
		// (get) Token: 0x060079FF RID: 31231 RVA: 0x002126A8 File Offset: 0x002108A8
		// (set) Token: 0x06007A00 RID: 31232 RVA: 0x000398A6 File Offset: 0x00037AA6
		public unsafe Vector3 Velocity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_Velocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_Velocity)) = value;
			}
		}

		// Token: 0x170024A9 RID: 9385
		// (get) Token: 0x06007A01 RID: 31233 RVA: 0x002126D0 File Offset: 0x002108D0
		// (set) Token: 0x06007A02 RID: 31234 RVA: 0x000398C1 File Offset: 0x00037AC1
		public unsafe float SampleLength
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_SampleLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_SampleLength)) = value;
			}
		}

		// Token: 0x170024AA RID: 9386
		// (get) Token: 0x06007A03 RID: 31235 RVA: 0x002126F8 File Offset: 0x002108F8
		// (set) Token: 0x06007A04 RID: 31236 RVA: 0x000398DC File Offset: 0x00037ADC
		public unsafe float MaxReasonableVelocity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_MaxReasonableVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_MaxReasonableVelocity)) = value;
			}
		}

		// Token: 0x170024AB RID: 9387
		// (get) Token: 0x06007A05 RID: 31237 RVA: 0x00212720 File Offset: 0x00210920
		// (set) Token: 0x06007A06 RID: 31238 RVA: 0x000398F7 File Offset: 0x00037AF7
		public unsafe List<Il2CppSystem.Tuple<Vector3, float>> VelocityHistory
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_VelocityHistory);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Tuple<Vector3, float>>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_VelocityHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024AC RID: 9388
		// (get) Token: 0x06007A07 RID: 31239 RVA: 0x00212750 File Offset: 0x00210950
		// (set) Token: 0x06007A08 RID: 31240 RVA: 0x00039916 File Offset: 0x00037B16
		public unsafe int maxSamples
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_maxSamples);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_maxSamples)) = value;
			}
		}

		// Token: 0x170024AD RID: 9389
		// (get) Token: 0x06007A09 RID: 31241 RVA: 0x00212778 File Offset: 0x00210978
		// (set) Token: 0x06007A0A RID: 31242 RVA: 0x00039931 File Offset: 0x00037B31
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x170024AE RID: 9390
		// (get) Token: 0x06007A0B RID: 31243 RVA: 0x002127A0 File Offset: 0x002109A0
		// (set) Token: 0x06007A0C RID: 31244 RVA: 0x0003994C File Offset: 0x00037B4C
		public unsafe bool zeroOut
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_zeroOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_zeroOut)) = value;
			}
		}

		// Token: 0x04005330 RID: 21296
		private static readonly System.IntPtr NativeFieldInfoPtr_Velocity;

		// Token: 0x04005331 RID: 21297
		private static readonly System.IntPtr NativeFieldInfoPtr_SampleLength;

		// Token: 0x04005332 RID: 21298
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxReasonableVelocity;

		// Token: 0x04005333 RID: 21299
		private static readonly System.IntPtr NativeFieldInfoPtr_VelocityHistory;

		// Token: 0x04005334 RID: 21300
		private static readonly System.IntPtr NativeFieldInfoPtr_maxSamples;

		// Token: 0x04005335 RID: 21301
		private static readonly System.IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x04005336 RID: 21302
		private static readonly System.IntPtr NativeFieldInfoPtr_zeroOut;

		// Token: 0x04005337 RID: 21303
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005338 RID: 21304
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04005339 RID: 21305
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAverageVelocity_Private_Vector3_0;

		// Token: 0x0400533A RID: 21306
		private static readonly System.IntPtr NativeMethodInfoPtr_FlushBuffer_Public_Void_0;

		// Token: 0x0400533B RID: 21307
		private static readonly System.IntPtr NativeMethodInfoPtr_ZeroOut_Public_Void_Single_0;

		// Token: 0x0400533C RID: 21308
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AF3 RID: 2803
		[ObfuscatedName("ScheduleOne.Tools.SmoothedVelocityCalculator+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D854 RID: 55380 RVA: 0x0033D544 File Offset: 0x0033B744
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr);
				SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr, "duration");
				SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr, 100678734);
				SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr, 100678735);
			}

			// Token: 0x0600D855 RID: 55381 RVA: 0x0033D5C0 File Offset: 0x0033B7C0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D856 RID: 55382 RVA: 0x0033D5FC File Offset: 0x0033B7FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235955, XrefRangeEnd = 235960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D857 RID: 55383 RVA: 0x00068F94 File Offset: 0x00067194
			public __c__DisplayClass11_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042C7 RID: 17095
			// (get) Token: 0x0600D858 RID: 55384 RVA: 0x0033D63C File Offset: 0x0033B83C
			// (set) Token: 0x0600D859 RID: 55385 RVA: 0x00068F9D File Offset: 0x0006719D
			public unsafe float duration
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x170042C8 RID: 17096
			// (get) Token: 0x0600D85A RID: 55386 RVA: 0x0033D664 File Offset: 0x0033B864
			// (set) Token: 0x0600D85B RID: 55387 RVA: 0x00068FB8 File Offset: 0x000671B8
			public unsafe SmoothedVelocityCalculator __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091D3 RID: 37331
			private static readonly System.IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x040091D4 RID: 37332
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091D5 RID: 37333
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091D6 RID: 37334
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CBE RID: 3262
			[ObfuscatedName("ScheduleOne.Tools.SmoothedVelocityCalculator+<>c__DisplayClass11_0+<<ZeroOut>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E9DD RID: 59869 RVA: 0x0036F84C File Offset: 0x0036DA4C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0>.NativeClassPtr, "<<ZeroOut>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678736);
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678737);
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678738);
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678739);
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678740);
					SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678741);
				}

				// Token: 0x0600E9DE RID: 59870 RVA: 0x0036F92C File Offset: 0x0036DB2C
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E9DF RID: 59871 RVA: 0x0036F974 File Offset: 0x0036DB74
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E9E0 RID: 59872 RVA: 0x0036F9A8 File Offset: 0x0036DBA8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235945, XrefRangeEnd = 235950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004850 RID: 18512
				// (get) Token: 0x0600E9E1 RID: 59873 RVA: 0x0036F9E4 File Offset: 0x0036DBE4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E9E2 RID: 59874 RVA: 0x0036FA24 File Offset: 0x0036DC24
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235950, XrefRangeEnd = 235955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004851 RID: 18513
				// (get) Token: 0x0600E9E3 RID: 59875 RVA: 0x0036FA58 File Offset: 0x0036DC58
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E9E4 RID: 59876 RVA: 0x00071B7C File Offset: 0x0006FD7C
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700484D RID: 18509
				// (get) Token: 0x0600E9E5 RID: 59877 RVA: 0x0036FA98 File Offset: 0x0036DC98
				// (set) Token: 0x0600E9E6 RID: 59878 RVA: 0x00071B85 File Offset: 0x0006FD85
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700484E RID: 18510
				// (get) Token: 0x0600E9E7 RID: 59879 RVA: 0x0036FAC0 File Offset: 0x0036DCC0
				// (set) Token: 0x0600E9E8 RID: 59880 RVA: 0x00071BA0 File Offset: 0x0006FDA0
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700484F RID: 18511
				// (get) Token: 0x0600E9E9 RID: 59881 RVA: 0x0036FAF0 File Offset: 0x0036DCF0
				// (set) Token: 0x0600E9EA RID: 59882 RVA: 0x00071BBF File Offset: 0x0006FDBF
				public unsafe SmoothedVelocityCalculator.__c__DisplayClass11_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator.__c__DisplayClass11_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009C7C RID: 40060
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009C7D RID: 40061
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009C7E RID: 40062
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009C7F RID: 40063
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009C80 RID: 40064
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C81 RID: 40065
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009C82 RID: 40066
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009C83 RID: 40067
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C84 RID: 40068
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
