using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000216 RID: 534
	public class FinalizeLabOven : Task
	{
		// Token: 0x06002BDE RID: 11230 RVA: 0x000FE4E8 File Offset: 0x000FC6E8
		// Note: this type is marked as 'beforefieldinit'.
		static FinalizeLabOven()
		{
			Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "FinalizeLabOven");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr);
			FinalizeLabOven.NativeFieldInfoPtr_MAX_DISTANCE_FROM_IMPACT_POINT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "MAX_DISTANCE_FROM_IMPACT_POINT");
			FinalizeLabOven.NativeFieldInfoPtr_SMASH_VELOCITY_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "SMASH_VELOCITY_THRESHOLD");
			FinalizeLabOven.NativeFieldInfoPtr_REQUIRED_IMPACTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "REQUIRED_IMPACTS");
			FinalizeLabOven.NativeFieldInfoPtr__Oven_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "<Oven>k__BackingField");
			FinalizeLabOven.NativeFieldInfoPtr_startSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "startSequence");
			FinalizeLabOven.NativeFieldInfoPtr_hammer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "hammer");
			FinalizeLabOven.NativeFieldInfoPtr_impactCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "impactCount");
			FinalizeLabOven.NativeFieldInfoPtr_timeSinceLastImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "timeSinceLastImpact");
			FinalizeLabOven.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668255);
			FinalizeLabOven.NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668256);
			FinalizeLabOven.NativeMethodInfoPtr__ctor_Public_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668257);
			FinalizeLabOven.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668258);
			FinalizeLabOven.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668259);
			FinalizeLabOven.NativeMethodInfoPtr_StartSequence_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668260);
			FinalizeLabOven.NativeMethodInfoPtr_Collision_Public_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668261);
			FinalizeLabOven.NativeMethodInfoPtr_Shatter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668262);
			FinalizeLabOven.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, 100668263);
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06002BDF RID: 11231 RVA: 0x000FE66C File Offset: 0x000FC86C
		// (set) Token: 0x06002BE0 RID: 11232 RVA: 0x000FE6AC File Offset: 0x000FC8AC
		public unsafe LabOven Oven
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45432, RefRangeEnd = 45433, XrefRangeStart = 45432, XrefRangeEnd = 45433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x000FE6F0 File Offset: 0x000FC8F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125143, RefRangeEnd = 125144, XrefRangeStart = 125122, XrefRangeEnd = 125143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FinalizeLabOven(LabOven oven) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr__ctor_Public_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x000FE73C File Offset: 0x000FC93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125144, XrefRangeEnd = 125146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FinalizeLabOven.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x000FE778 File Offset: 0x000FC978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125146, XrefRangeEnd = 125178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FinalizeLabOven.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x000FE7B4 File Offset: 0x000FC9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125178, XrefRangeEnd = 125183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StartSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr_StartSequence_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x000FE7F4 File Offset: 0x000FC9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125183, XrefRangeEnd = 125209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Collision(Collision col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr_Collision_Public_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x000FE838 File Offset: 0x000FCA38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125236, RefRangeEnd = 125237, XrefRangeStart = 125209, XrefRangeEnd = 125236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Shatter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr_Shatter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x000FE86C File Offset: 0x000FCA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125237, XrefRangeEnd = 125242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x00017A66 File Offset: 0x00015C66
		public FinalizeLabOven(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06002BE9 RID: 11241 RVA: 0x000FE8AC File Offset: 0x000FCAAC
		// (set) Token: 0x06002BEA RID: 11242 RVA: 0x00017A6F File Offset: 0x00015C6F
		public unsafe static float MAX_DISTANCE_FROM_IMPACT_POINT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FinalizeLabOven.NativeFieldInfoPtr_MAX_DISTANCE_FROM_IMPACT_POINT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FinalizeLabOven.NativeFieldInfoPtr_MAX_DISTANCE_FROM_IMPACT_POINT, (void*)(&value));
			}
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06002BEB RID: 11243 RVA: 0x000FE8C8 File Offset: 0x000FCAC8
		// (set) Token: 0x06002BEC RID: 11244 RVA: 0x00017A7D File Offset: 0x00015C7D
		public unsafe float SMASH_VELOCITY_THRESHOLD
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_SMASH_VELOCITY_THRESHOLD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_SMASH_VELOCITY_THRESHOLD)) = value;
			}
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06002BED RID: 11245 RVA: 0x000FE8F0 File Offset: 0x000FCAF0
		// (set) Token: 0x06002BEE RID: 11246 RVA: 0x00017A98 File Offset: 0x00015C98
		public unsafe static int REQUIRED_IMPACTS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FinalizeLabOven.NativeFieldInfoPtr_REQUIRED_IMPACTS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FinalizeLabOven.NativeFieldInfoPtr_REQUIRED_IMPACTS, (void*)(&value));
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06002BEF RID: 11247 RVA: 0x000FE90C File Offset: 0x000FCB0C
		// (set) Token: 0x06002BF0 RID: 11248 RVA: 0x00017AA6 File Offset: 0x00015CA6
		public unsafe LabOven _Oven_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr__Oven_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr__Oven_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06002BF1 RID: 11249 RVA: 0x000FE93C File Offset: 0x000FCB3C
		// (set) Token: 0x06002BF2 RID: 11250 RVA: 0x00017AC5 File Offset: 0x00015CC5
		public unsafe Coroutine startSequence
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_startSequence);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_startSequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06002BF3 RID: 11251 RVA: 0x000FE96C File Offset: 0x000FCB6C
		// (set) Token: 0x06002BF4 RID: 11252 RVA: 0x00017AE4 File Offset: 0x00015CE4
		public unsafe LabOvenHammer hammer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_hammer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOvenHammer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_hammer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x000FE99C File Offset: 0x000FCB9C
		// (set) Token: 0x06002BF6 RID: 11254 RVA: 0x00017B03 File Offset: 0x00015D03
		public unsafe int impactCount
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_impactCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_impactCount)) = value;
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06002BF7 RID: 11255 RVA: 0x000FE9C4 File Offset: 0x000FCBC4
		// (set) Token: 0x06002BF8 RID: 11256 RVA: 0x00017B1E File Offset: 0x00015D1E
		public unsafe float timeSinceLastImpact
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_timeSinceLastImpact);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.NativeFieldInfoPtr_timeSinceLastImpact)) = value;
			}
		}

		// Token: 0x04001D16 RID: 7446
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_DISTANCE_FROM_IMPACT_POINT;

		// Token: 0x04001D17 RID: 7447
		private static readonly System.IntPtr NativeFieldInfoPtr_SMASH_VELOCITY_THRESHOLD;

		// Token: 0x04001D18 RID: 7448
		private static readonly System.IntPtr NativeFieldInfoPtr_REQUIRED_IMPACTS;

		// Token: 0x04001D19 RID: 7449
		private static readonly System.IntPtr NativeFieldInfoPtr__Oven_k__BackingField;

		// Token: 0x04001D1A RID: 7450
		private static readonly System.IntPtr NativeFieldInfoPtr_startSequence;

		// Token: 0x04001D1B RID: 7451
		private static readonly System.IntPtr NativeFieldInfoPtr_hammer;

		// Token: 0x04001D1C RID: 7452
		private static readonly System.IntPtr NativeFieldInfoPtr_impactCount;

		// Token: 0x04001D1D RID: 7453
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceLastImpact;

		// Token: 0x04001D1E RID: 7454
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0;

		// Token: 0x04001D1F RID: 7455
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0;

		// Token: 0x04001D20 RID: 7456
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_LabOven_0;

		// Token: 0x04001D21 RID: 7457
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001D22 RID: 7458
		private static readonly System.IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001D23 RID: 7459
		private static readonly System.IntPtr NativeMethodInfoPtr_StartSequence_Private_IEnumerator_0;

		// Token: 0x04001D24 RID: 7460
		private static readonly System.IntPtr NativeMethodInfoPtr_Collision_Public_Void_Collision_0;

		// Token: 0x04001D25 RID: 7461
		private static readonly System.IntPtr NativeMethodInfoPtr_Shatter_Private_Void_0;

		// Token: 0x04001D26 RID: 7462
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000915 RID: 2325
		[ObfuscatedName("ScheduleOne.PlayerTasks.FinalizeLabOven+<<Shatter>g__Routine|16_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C8F9 RID: 51449 RVA: 0x00311A04 File Offset: 0x0030FC04
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique()
			{
				Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "<<Shatter>g__Routine|16_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr);
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, "<>1__state");
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, "<>2__current");
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, "<>4__this");
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100668264);
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100668265);
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100668266);
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100668267);
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100668268);
				FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100668269);
			}

			// Token: 0x0600C8FA RID: 51450 RVA: 0x00311AE4 File Offset: 0x0030FCE4
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C8FB RID: 51451 RVA: 0x00311B2C File Offset: 0x0030FD2C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C8FC RID: 51452 RVA: 0x00311B60 File Offset: 0x0030FD60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125091, XrefRangeEnd = 125096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003E74 RID: 15988
			// (get) Token: 0x0600C8FD RID: 51453 RVA: 0x00311B9C File Offset: 0x0030FD9C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C8FE RID: 51454 RVA: 0x00311BDC File Offset: 0x0030FDDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125096, XrefRangeEnd = 125101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003E75 RID: 15989
			// (get) Token: 0x0600C8FF RID: 51455 RVA: 0x00311C10 File Offset: 0x0030FE10
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C900 RID: 51456 RVA: 0x00061788 File Offset: 0x0005F988
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E71 RID: 15985
			// (get) Token: 0x0600C901 RID: 51457 RVA: 0x00311C50 File Offset: 0x0030FE50
			// (set) Token: 0x0600C902 RID: 51458 RVA: 0x00061791 File Offset: 0x0005F991
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E72 RID: 15986
			// (get) Token: 0x0600C903 RID: 51459 RVA: 0x00311C78 File Offset: 0x0030FE78
			// (set) Token: 0x0600C904 RID: 51460 RVA: 0x000617AC File Offset: 0x0005F9AC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E73 RID: 15987
			// (get) Token: 0x0600C905 RID: 51461 RVA: 0x00311CA8 File Offset: 0x0030FEA8
			// (set) Token: 0x0600C906 RID: 51462 RVA: 0x000617CB File Offset: 0x0005F9CB
			public unsafe FinalizeLabOven __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FinalizeLabOven>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008856 RID: 34902
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008857 RID: 34903
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008858 RID: 34904
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008859 RID: 34905
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400885A RID: 34906
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400885B RID: 34907
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400885C RID: 34908
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400885D RID: 34909
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400885E RID: 34910
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000916 RID: 2326
		[ObfuscatedName("ScheduleOne.PlayerTasks.FinalizeLabOven+<StartSequence>d__14")]
		public sealed class _StartSequence_d__14 : Il2CppSystem.Object
		{
			// Token: 0x0600C907 RID: 51463 RVA: 0x00311CD8 File Offset: 0x0030FED8
			// Note: this type is marked as 'beforefieldinit'.
			static _StartSequence_d__14()
			{
				Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalizeLabOven>.NativeClassPtr, "<StartSequence>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr);
				FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, "<>1__state");
				FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, "<>2__current");
				FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, "<>4__this");
				FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, 100668270);
				FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, 100668271);
				FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, 100668272);
				FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, 100668273);
				FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, 100668274);
				FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr, 100668275);
			}

			// Token: 0x0600C908 RID: 51464 RVA: 0x00311DB8 File Offset: 0x0030FFB8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StartSequence_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalizeLabOven._StartSequence_d__14>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C909 RID: 51465 RVA: 0x00311E00 File Offset: 0x00310000
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C90A RID: 51466 RVA: 0x00311E34 File Offset: 0x00310034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125101, XrefRangeEnd = 125117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003E79 RID: 15993
			// (get) Token: 0x0600C90B RID: 51467 RVA: 0x00311E70 File Offset: 0x00310070
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C90C RID: 51468 RVA: 0x00311EB0 File Offset: 0x003100B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125117, XrefRangeEnd = 125122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003E7A RID: 15994
			// (get) Token: 0x0600C90D RID: 51469 RVA: 0x00311EE4 File Offset: 0x003100E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinalizeLabOven._StartSequence_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C90E RID: 51470 RVA: 0x000617EA File Offset: 0x0005F9EA
			public _StartSequence_d__14(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E76 RID: 15990
			// (get) Token: 0x0600C90F RID: 51471 RVA: 0x00311F24 File Offset: 0x00310124
			// (set) Token: 0x0600C910 RID: 51472 RVA: 0x000617F3 File Offset: 0x0005F9F3
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E77 RID: 15991
			// (get) Token: 0x0600C911 RID: 51473 RVA: 0x00311F4C File Offset: 0x0031014C
			// (set) Token: 0x0600C912 RID: 51474 RVA: 0x0006180E File Offset: 0x0005FA0E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E78 RID: 15992
			// (get) Token: 0x0600C913 RID: 51475 RVA: 0x00311F7C File Offset: 0x0031017C
			// (set) Token: 0x0600C914 RID: 51476 RVA: 0x0006182D File Offset: 0x0005FA2D
			public unsafe FinalizeLabOven __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FinalizeLabOven>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FinalizeLabOven._StartSequence_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400885F RID: 34911
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008860 RID: 34912
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008861 RID: 34913
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008862 RID: 34914
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008863 RID: 34915
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008864 RID: 34916
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008865 RID: 34917
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008866 RID: 34918
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008867 RID: 34919
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
