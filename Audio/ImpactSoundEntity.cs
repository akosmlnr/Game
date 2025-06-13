using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004F6 RID: 1270
	public class ImpactSoundEntity : MonoBehaviour
	{
		// Token: 0x06006E24 RID: 28196 RVA: 0x001EB340 File Offset: 0x001E9540
		// Note: this type is marked as 'beforefieldinit'.
		static ImpactSoundEntity()
		{
			Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "ImpactSoundEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr);
			ImpactSoundEntity.NativeFieldInfoPtr_MIN_IMPACT_MOMENTUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, "MIN_IMPACT_MOMENTUM");
			ImpactSoundEntity.NativeFieldInfoPtr_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, "COOLDOWN");
			ImpactSoundEntity.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, "Material");
			ImpactSoundEntity.NativeFieldInfoPtr_lastImpactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, "lastImpactTime");
			ImpactSoundEntity.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, "rb");
			ImpactSoundEntity.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, 100677312);
			ImpactSoundEntity.NativeMethodInfoPtr_OnImpacted_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, 100677313);
			ImpactSoundEntity.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, 100677314);
			ImpactSoundEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr, 100677315);
		}

		// Token: 0x06006E25 RID: 28197 RVA: 0x001EB424 File Offset: 0x001E9624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220910, XrefRangeEnd = 220937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactSoundEntity.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E26 RID: 28198 RVA: 0x001EB458 File Offset: 0x001E9658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220937, XrefRangeEnd = 220950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnImpacted(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactSoundEntity.NativeMethodInfoPtr_OnImpacted_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E27 RID: 28199 RVA: 0x001EB49C File Offset: 0x001E969C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220950, XrefRangeEnd = 220977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactSoundEntity.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E28 RID: 28200 RVA: 0x001EB4E0 File Offset: 0x001E96E0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImpactSoundEntity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactSoundEntity>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactSoundEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E29 RID: 28201 RVA: 0x00033E85 File Offset: 0x00032085
		public ImpactSoundEntity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x06006E2A RID: 28202 RVA: 0x001EB51C File Offset: 0x001E971C
		// (set) Token: 0x06006E2B RID: 28203 RVA: 0x00033E8E File Offset: 0x0003208E
		public unsafe static float MIN_IMPACT_MOMENTUM
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ImpactSoundEntity.NativeFieldInfoPtr_MIN_IMPACT_MOMENTUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImpactSoundEntity.NativeFieldInfoPtr_MIN_IMPACT_MOMENTUM, (void*)(&value));
			}
		}

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x06006E2C RID: 28204 RVA: 0x001EB538 File Offset: 0x001E9738
		// (set) Token: 0x06006E2D RID: 28205 RVA: 0x00033E9C File Offset: 0x0003209C
		public unsafe static float COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ImpactSoundEntity.NativeFieldInfoPtr_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImpactSoundEntity.NativeFieldInfoPtr_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x06006E2E RID: 28206 RVA: 0x001EB554 File Offset: 0x001E9754
		// (set) Token: 0x06006E2F RID: 28207 RVA: 0x00033EAA File Offset: 0x000320AA
		public unsafe ImpactSoundEntity.EMaterial Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactSoundEntity.NativeFieldInfoPtr_Material);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactSoundEntity.NativeFieldInfoPtr_Material)) = value;
			}
		}

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x06006E30 RID: 28208 RVA: 0x001EB57C File Offset: 0x001E977C
		// (set) Token: 0x06006E31 RID: 28209 RVA: 0x00033EC5 File Offset: 0x000320C5
		public unsafe float lastImpactTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactSoundEntity.NativeFieldInfoPtr_lastImpactTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactSoundEntity.NativeFieldInfoPtr_lastImpactTime)) = value;
			}
		}

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x06006E32 RID: 28210 RVA: 0x001EB5A4 File Offset: 0x001E97A4
		// (set) Token: 0x06006E33 RID: 28211 RVA: 0x00033EE0 File Offset: 0x000320E0
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactSoundEntity.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactSoundEntity.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B53 RID: 19283
		private static readonly IntPtr NativeFieldInfoPtr_MIN_IMPACT_MOMENTUM;

		// Token: 0x04004B54 RID: 19284
		private static readonly IntPtr NativeFieldInfoPtr_COOLDOWN;

		// Token: 0x04004B55 RID: 19285
		private static readonly IntPtr NativeFieldInfoPtr_Material;

		// Token: 0x04004B56 RID: 19286
		private static readonly IntPtr NativeFieldInfoPtr_lastImpactTime;

		// Token: 0x04004B57 RID: 19287
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04004B58 RID: 19288
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04004B59 RID: 19289
		private static readonly IntPtr NativeMethodInfoPtr_OnImpacted_Private_Void_Impact_0;

		// Token: 0x04004B5A RID: 19290
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x04004B5B RID: 19291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AAB RID: 2731
		[OriginalName("Assembly-CSharp.dll", "", "EMaterial")]
		public enum EMaterial
		{
			// Token: 0x04009058 RID: 36952
			Wood,
			// Token: 0x04009059 RID: 36953
			HollowMetal,
			// Token: 0x0400905A RID: 36954
			Cardboard,
			// Token: 0x0400905B RID: 36955
			Glass,
			// Token: 0x0400905C RID: 36956
			Plastic,
			// Token: 0x0400905D RID: 36957
			Basketball,
			// Token: 0x0400905E RID: 36958
			SmallHollowMetal,
			// Token: 0x0400905F RID: 36959
			PlasticBag,
			// Token: 0x04009060 RID: 36960
			Punch,
			// Token: 0x04009061 RID: 36961
			BaseballBat
		}
	}
}
