using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000562 RID: 1378
	public class MonoBehaviourEvents : MonoBehaviour
	{
		// Token: 0x0600792E RID: 31022 RVA: 0x002100A4 File Offset: 0x0020E2A4
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBehaviourEvents()
		{
			Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "MonoBehaviourEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr);
			MonoBehaviourEvents.NativeFieldInfoPtr_onAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, "onAwake");
			MonoBehaviourEvents.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, "onStart");
			MonoBehaviourEvents.NativeFieldInfoPtr_onUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, "onUpdate");
			MonoBehaviourEvents.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, 100678663);
			MonoBehaviourEvents.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, 100678664);
			MonoBehaviourEvents.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, 100678665);
			MonoBehaviourEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, 100678666);
		}

		// Token: 0x0600792F RID: 31023 RVA: 0x00210160 File Offset: 0x0020E360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235244, XrefRangeEnd = 235245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourEvents.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007930 RID: 31024 RVA: 0x00210194 File Offset: 0x0020E394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235245, XrefRangeEnd = 235246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourEvents.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007931 RID: 31025 RVA: 0x002101C8 File Offset: 0x0020E3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235246, XrefRangeEnd = 235247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourEvents.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007932 RID: 31026 RVA: 0x002101FC File Offset: 0x0020E3FC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBehaviourEvents() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007933 RID: 31027 RVA: 0x0003926F File Offset: 0x0003746F
		public MonoBehaviourEvents(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002474 RID: 9332
		// (get) Token: 0x06007934 RID: 31028 RVA: 0x00210238 File Offset: 0x0020E438
		// (set) Token: 0x06007935 RID: 31029 RVA: 0x00039278 File Offset: 0x00037478
		public unsafe UnityEvent onAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onAwake);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onAwake), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002475 RID: 9333
		// (get) Token: 0x06007936 RID: 31030 RVA: 0x00210268 File Offset: 0x0020E468
		// (set) Token: 0x06007937 RID: 31031 RVA: 0x00039297 File Offset: 0x00037497
		public unsafe UnityEvent onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002476 RID: 9334
		// (get) Token: 0x06007938 RID: 31032 RVA: 0x00210298 File Offset: 0x0020E498
		// (set) Token: 0x06007939 RID: 31033 RVA: 0x000392B6 File Offset: 0x000374B6
		public unsafe UnityEvent onUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040052BC RID: 21180
		private static readonly IntPtr NativeFieldInfoPtr_onAwake;

		// Token: 0x040052BD RID: 21181
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x040052BE RID: 21182
		private static readonly IntPtr NativeFieldInfoPtr_onUpdate;

		// Token: 0x040052BF RID: 21183
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040052C0 RID: 21184
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040052C1 RID: 21185
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040052C2 RID: 21186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
