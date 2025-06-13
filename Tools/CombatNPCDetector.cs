using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000554 RID: 1364
	public class CombatNPCDetector : MonoBehaviour
	{
		// Token: 0x0600788E RID: 30862 RVA: 0x0020E294 File Offset: 0x0020C494
		// Note: this type is marked as 'beforefieldinit'.
		static CombatNPCDetector()
		{
			Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CombatNPCDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr);
			CombatNPCDetector.NativeFieldInfoPtr_DetectOnlyInCombat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "DetectOnlyInCombat");
			CombatNPCDetector.NativeFieldInfoPtr_onDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "onDetected");
			CombatNPCDetector.NativeFieldInfoPtr_ContactTimeForDetection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "ContactTimeForDetection");
			CombatNPCDetector.NativeFieldInfoPtr_contactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "contactTime");
			CombatNPCDetector.NativeFieldInfoPtr_timeSinceLastContact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "timeSinceLastContact");
			CombatNPCDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, 100678579);
			CombatNPCDetector.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, 100678580);
			CombatNPCDetector.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, 100678581);
			CombatNPCDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, 100678582);
		}

		// Token: 0x0600788F RID: 30863 RVA: 0x0020E378 File Offset: 0x0020C578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234682, XrefRangeEnd = 234695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007890 RID: 30864 RVA: 0x0020E3AC File Offset: 0x0020C5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234695, XrefRangeEnd = 234699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007891 RID: 30865 RVA: 0x0020E3E0 File Offset: 0x0020C5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234699, XrefRangeEnd = 234713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007892 RID: 30866 RVA: 0x0020E424 File Offset: 0x0020C624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234713, XrefRangeEnd = 234714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CombatNPCDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007893 RID: 30867 RVA: 0x00038DF1 File Offset: 0x00036FF1
		public CombatNPCDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700244C RID: 9292
		// (get) Token: 0x06007894 RID: 30868 RVA: 0x0020E460 File Offset: 0x0020C660
		// (set) Token: 0x06007895 RID: 30869 RVA: 0x00038DFA File Offset: 0x00036FFA
		public unsafe bool DetectOnlyInCombat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_DetectOnlyInCombat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_DetectOnlyInCombat)) = value;
			}
		}

		// Token: 0x1700244D RID: 9293
		// (get) Token: 0x06007896 RID: 30870 RVA: 0x0020E488 File Offset: 0x0020C688
		// (set) Token: 0x06007897 RID: 30871 RVA: 0x00038E15 File Offset: 0x00037015
		public unsafe UnityEvent onDetected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_onDetected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_onDetected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700244E RID: 9294
		// (get) Token: 0x06007898 RID: 30872 RVA: 0x0020E4B8 File Offset: 0x0020C6B8
		// (set) Token: 0x06007899 RID: 30873 RVA: 0x00038E34 File Offset: 0x00037034
		public unsafe float ContactTimeForDetection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_ContactTimeForDetection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_ContactTimeForDetection)) = value;
			}
		}

		// Token: 0x1700244F RID: 9295
		// (get) Token: 0x0600789A RID: 30874 RVA: 0x0020E4E0 File Offset: 0x0020C6E0
		// (set) Token: 0x0600789B RID: 30875 RVA: 0x00038E4F File Offset: 0x0003704F
		public unsafe float contactTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_contactTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_contactTime)) = value;
			}
		}

		// Token: 0x17002450 RID: 9296
		// (get) Token: 0x0600789C RID: 30876 RVA: 0x0020E508 File Offset: 0x0020C708
		// (set) Token: 0x0600789D RID: 30877 RVA: 0x00038E6A File Offset: 0x0003706A
		public unsafe float timeSinceLastContact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_timeSinceLastContact);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_timeSinceLastContact)) = value;
			}
		}

		// Token: 0x0400525C RID: 21084
		private static readonly IntPtr NativeFieldInfoPtr_DetectOnlyInCombat;

		// Token: 0x0400525D RID: 21085
		private static readonly IntPtr NativeFieldInfoPtr_onDetected;

		// Token: 0x0400525E RID: 21086
		private static readonly IntPtr NativeFieldInfoPtr_ContactTimeForDetection;

		// Token: 0x0400525F RID: 21087
		private static readonly IntPtr NativeFieldInfoPtr_contactTime;

		// Token: 0x04005260 RID: 21088
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastContact;

		// Token: 0x04005261 RID: 21089
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005262 RID: 21090
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04005263 RID: 21091
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x04005264 RID: 21092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
