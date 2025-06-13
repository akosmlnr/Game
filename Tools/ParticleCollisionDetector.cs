using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000566 RID: 1382
	public class ParticleCollisionDetector : MonoBehaviour
	{
		// Token: 0x06007964 RID: 31076 RVA: 0x00210A18 File Offset: 0x0020EC18
		// Note: this type is marked as 'beforefieldinit'.
		static ParticleCollisionDetector()
		{
			Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ParticleCollisionDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr);
			ParticleCollisionDetector.NativeFieldInfoPtr_onCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, "onCollision");
			ParticleCollisionDetector.NativeFieldInfoPtr_ps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, "ps");
			ParticleCollisionDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, 100678681);
			ParticleCollisionDetector.NativeMethodInfoPtr_OnParticleCollision_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, 100678682);
			ParticleCollisionDetector.NativeMethodInfoPtr_OnParticleTrigger_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, 100678683);
			ParticleCollisionDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, 100678684);
		}

		// Token: 0x06007965 RID: 31077 RVA: 0x00210AC0 File Offset: 0x0020ECC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235398, XrefRangeEnd = 235402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleCollisionDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007966 RID: 31078 RVA: 0x00210AF4 File Offset: 0x0020ECF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235402, XrefRangeEnd = 235405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnParticleCollision(GameObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleCollisionDetector.NativeMethodInfoPtr_OnParticleCollision_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007967 RID: 31079 RVA: 0x00210B38 File Offset: 0x0020ED38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235405, XrefRangeEnd = 235415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnParticleTrigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleCollisionDetector.NativeMethodInfoPtr_OnParticleTrigger_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007968 RID: 31080 RVA: 0x00210B6C File Offset: 0x0020ED6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235415, XrefRangeEnd = 235423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleCollisionDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleCollisionDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007969 RID: 31081 RVA: 0x0003940F File Offset: 0x0003760F
		public ParticleCollisionDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002482 RID: 9346
		// (get) Token: 0x0600796A RID: 31082 RVA: 0x00210BA8 File Offset: 0x0020EDA8
		// (set) Token: 0x0600796B RID: 31083 RVA: 0x00039418 File Offset: 0x00037618
		public unsafe UnityEvent<GameObject> onCollision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleCollisionDetector.NativeFieldInfoPtr_onCollision);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleCollisionDetector.NativeFieldInfoPtr_onCollision), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002483 RID: 9347
		// (get) Token: 0x0600796C RID: 31084 RVA: 0x00210BD8 File Offset: 0x0020EDD8
		// (set) Token: 0x0600796D RID: 31085 RVA: 0x00039437 File Offset: 0x00037637
		public unsafe ParticleSystem ps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleCollisionDetector.NativeFieldInfoPtr_ps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleCollisionDetector.NativeFieldInfoPtr_ps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040052DC RID: 21212
		private static readonly IntPtr NativeFieldInfoPtr_onCollision;

		// Token: 0x040052DD RID: 21213
		private static readonly IntPtr NativeFieldInfoPtr_ps;

		// Token: 0x040052DE RID: 21214
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040052DF RID: 21215
		private static readonly IntPtr NativeMethodInfoPtr_OnParticleCollision_Public_Void_GameObject_0;

		// Token: 0x040052E0 RID: 21216
		private static readonly IntPtr NativeMethodInfoPtr_OnParticleTrigger_Private_Void_0;

		// Token: 0x040052E1 RID: 21217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
