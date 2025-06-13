using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000569 RID: 1385
	public class PlayerDetector : MonoBehaviour
	{
		// Token: 0x0600797B RID: 31099 RVA: 0x00210F4C File Offset: 0x0020F14C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerDetector()
		{
			Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "PlayerDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr);
			PlayerDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "ACTIVATION_DISTANCE_SQ");
			PlayerDetector.NativeFieldInfoPtr_DetectPlayerInVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "DetectPlayerInVehicle");
			PlayerDetector.NativeFieldInfoPtr_onPlayerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "onPlayerEnter");
			PlayerDetector.NativeFieldInfoPtr_onPlayerExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "onPlayerExit");
			PlayerDetector.NativeFieldInfoPtr_onLocalPlayerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "onLocalPlayerEnter");
			PlayerDetector.NativeFieldInfoPtr_onLocalPlayerExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "onLocalPlayerExit");
			PlayerDetector.NativeFieldInfoPtr_DetectedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "DetectedPlayers");
			PlayerDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "<IgnoreNewDetections>k__BackingField");
			PlayerDetector.NativeFieldInfoPtr_ignoreExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "ignoreExit");
			PlayerDetector.NativeFieldInfoPtr_collidersEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "collidersEnabled");
			PlayerDetector.NativeFieldInfoPtr_detectionColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "detectionColliders");
			PlayerDetector.NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678694);
			PlayerDetector.NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678695);
			PlayerDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678696);
			PlayerDetector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678697);
			PlayerDetector.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678698);
			PlayerDetector.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678699);
			PlayerDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678700);
			PlayerDetector.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678701);
			PlayerDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678702);
			PlayerDetector.NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678703);
			PlayerDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678704);
		}

		// Token: 0x1700248F RID: 9359
		// (get) Token: 0x0600797C RID: 31100 RVA: 0x00211134 File Offset: 0x0020F334
		// (set) Token: 0x0600797D RID: 31101 RVA: 0x00211170 File Offset: 0x0020F370
		public unsafe bool IgnoreNewDetections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600797E RID: 31102 RVA: 0x002111B0 File Offset: 0x0020F3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235457, XrefRangeEnd = 235474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600797F RID: 31103 RVA: 0x002111E4 File Offset: 0x0020F3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235474, XrefRangeEnd = 235492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007980 RID: 31104 RVA: 0x00211218 File Offset: 0x0020F418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235492, XrefRangeEnd = 235510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007981 RID: 31105 RVA: 0x0021124C File Offset: 0x0020F44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235510, XrefRangeEnd = 235526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007982 RID: 31106 RVA: 0x00211280 File Offset: 0x0020F480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235526, XrefRangeEnd = 235579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007983 RID: 31107 RVA: 0x002112C4 File Offset: 0x0020F4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235579, XrefRangeEnd = 235592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007984 RID: 31108 RVA: 0x002112F8 File Offset: 0x0020F4F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235645, RefRangeEnd = 235646, XrefRangeStart = 235592, XrefRangeEnd = 235645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007985 RID: 31109 RVA: 0x0021133C File Offset: 0x0020F53C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 235653, RefRangeEnd = 235655, XrefRangeStart = 235646, XrefRangeEnd = 235653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIgnoreNewCollisions(bool ignore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ignore;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007986 RID: 31110 RVA: 0x0021137C File Offset: 0x0020F57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235655, XrefRangeEnd = 235663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007987 RID: 31111 RVA: 0x00039468 File Offset: 0x00037668
		public PlayerDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002484 RID: 9348
		// (get) Token: 0x06007988 RID: 31112 RVA: 0x002113B8 File Offset: 0x0020F5B8
		// (set) Token: 0x06007989 RID: 31113 RVA: 0x00039471 File Offset: 0x00037671
		public unsafe static float ACTIVATION_DISTANCE_SQ
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ, (void*)(&value));
			}
		}

		// Token: 0x17002485 RID: 9349
		// (get) Token: 0x0600798A RID: 31114 RVA: 0x002113D4 File Offset: 0x0020F5D4
		// (set) Token: 0x0600798B RID: 31115 RVA: 0x0003947F File Offset: 0x0003767F
		public unsafe bool DetectPlayerInVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_DetectPlayerInVehicle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_DetectPlayerInVehicle)) = value;
			}
		}

		// Token: 0x17002486 RID: 9350
		// (get) Token: 0x0600798C RID: 31116 RVA: 0x002113FC File Offset: 0x0020F5FC
		// (set) Token: 0x0600798D RID: 31117 RVA: 0x0003949A File Offset: 0x0003769A
		public unsafe UnityEvent<Player> onPlayerEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onPlayerEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onPlayerEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002487 RID: 9351
		// (get) Token: 0x0600798E RID: 31118 RVA: 0x0021142C File Offset: 0x0020F62C
		// (set) Token: 0x0600798F RID: 31119 RVA: 0x000394B9 File Offset: 0x000376B9
		public unsafe UnityEvent<Player> onPlayerExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onPlayerExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onPlayerExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002488 RID: 9352
		// (get) Token: 0x06007990 RID: 31120 RVA: 0x0021145C File Offset: 0x0020F65C
		// (set) Token: 0x06007991 RID: 31121 RVA: 0x000394D8 File Offset: 0x000376D8
		public unsafe UnityEvent onLocalPlayerEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onLocalPlayerEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onLocalPlayerEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002489 RID: 9353
		// (get) Token: 0x06007992 RID: 31122 RVA: 0x0021148C File Offset: 0x0020F68C
		// (set) Token: 0x06007993 RID: 31123 RVA: 0x000394F7 File Offset: 0x000376F7
		public unsafe UnityEvent onLocalPlayerExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onLocalPlayerExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onLocalPlayerExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700248A RID: 9354
		// (get) Token: 0x06007994 RID: 31124 RVA: 0x002114BC File Offset: 0x0020F6BC
		// (set) Token: 0x06007995 RID: 31125 RVA: 0x00039516 File Offset: 0x00037716
		public unsafe List<Player> DetectedPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_DetectedPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_DetectedPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700248B RID: 9355
		// (get) Token: 0x06007996 RID: 31126 RVA: 0x002114EC File Offset: 0x0020F6EC
		// (set) Token: 0x06007997 RID: 31127 RVA: 0x00039535 File Offset: 0x00037735
		public unsafe bool _IgnoreNewDetections_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField)) = value;
			}
		}

		// Token: 0x1700248C RID: 9356
		// (get) Token: 0x06007998 RID: 31128 RVA: 0x00211514 File Offset: 0x0020F714
		// (set) Token: 0x06007999 RID: 31129 RVA: 0x00039550 File Offset: 0x00037750
		public unsafe bool ignoreExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_ignoreExit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_ignoreExit)) = value;
			}
		}

		// Token: 0x1700248D RID: 9357
		// (get) Token: 0x0600799A RID: 31130 RVA: 0x0021153C File Offset: 0x0020F73C
		// (set) Token: 0x0600799B RID: 31131 RVA: 0x0003956B File Offset: 0x0003776B
		public unsafe bool collidersEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_collidersEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_collidersEnabled)) = value;
			}
		}

		// Token: 0x1700248E RID: 9358
		// (get) Token: 0x0600799C RID: 31132 RVA: 0x00211564 File Offset: 0x0020F764
		// (set) Token: 0x0600799D RID: 31133 RVA: 0x00039586 File Offset: 0x00037786
		public unsafe Il2CppReferenceArray<Collider> detectionColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_detectionColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_detectionColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040052EB RID: 21227
		private static readonly IntPtr NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ;

		// Token: 0x040052EC RID: 21228
		private static readonly IntPtr NativeFieldInfoPtr_DetectPlayerInVehicle;

		// Token: 0x040052ED RID: 21229
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerEnter;

		// Token: 0x040052EE RID: 21230
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerExit;

		// Token: 0x040052EF RID: 21231
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerEnter;

		// Token: 0x040052F0 RID: 21232
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerExit;

		// Token: 0x040052F1 RID: 21233
		private static readonly IntPtr NativeFieldInfoPtr_DetectedPlayers;

		// Token: 0x040052F2 RID: 21234
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField;

		// Token: 0x040052F3 RID: 21235
		private static readonly IntPtr NativeFieldInfoPtr_ignoreExit;

		// Token: 0x040052F4 RID: 21236
		private static readonly IntPtr NativeFieldInfoPtr_collidersEnabled;

		// Token: 0x040052F5 RID: 21237
		private static readonly IntPtr NativeFieldInfoPtr_detectionColliders;

		// Token: 0x040052F6 RID: 21238
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0;

		// Token: 0x040052F7 RID: 21239
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0;

		// Token: 0x040052F8 RID: 21240
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040052F9 RID: 21241
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040052FA RID: 21242
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040052FB RID: 21243
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040052FC RID: 21244
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x040052FD RID: 21245
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040052FE RID: 21246
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;

		// Token: 0x040052FF RID: 21247
		private static readonly IntPtr NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0;

		// Token: 0x04005300 RID: 21248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
