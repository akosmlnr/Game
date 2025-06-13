using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000563 RID: 1379
	public class NPCWalkTo : MonoBehaviour
	{
		// Token: 0x0600793A RID: 31034 RVA: 0x002102C8 File Offset: 0x0020E4C8
		// Note: this type is marked as 'beforefieldinit'.
		static NPCWalkTo()
		{
			Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "NPCWalkTo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr);
			NPCWalkTo.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, "Target");
			NPCWalkTo.NativeFieldInfoPtr_RepathRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, "RepathRate");
			NPCWalkTo.NativeFieldInfoPtr_timeSinceLastPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, "timeSinceLastPath");
			NPCWalkTo.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, 100678667);
			NPCWalkTo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, 100678668);
		}

		// Token: 0x0600793B RID: 31035 RVA: 0x0021035C File Offset: 0x0020E55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235247, XrefRangeEnd = 235253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCWalkTo.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600793C RID: 31036 RVA: 0x00210390 File Offset: 0x0020E590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCWalkTo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCWalkTo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600793D RID: 31037 RVA: 0x000392D5 File Offset: 0x000374D5
		public NPCWalkTo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002477 RID: 9335
		// (get) Token: 0x0600793E RID: 31038 RVA: 0x002103CC File Offset: 0x0020E5CC
		// (set) Token: 0x0600793F RID: 31039 RVA: 0x000392DE File Offset: 0x000374DE
		public unsafe Transform Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002478 RID: 9336
		// (get) Token: 0x06007940 RID: 31040 RVA: 0x002103FC File Offset: 0x0020E5FC
		// (set) Token: 0x06007941 RID: 31041 RVA: 0x000392FD File Offset: 0x000374FD
		public unsafe float RepathRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_RepathRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_RepathRate)) = value;
			}
		}

		// Token: 0x17002479 RID: 9337
		// (get) Token: 0x06007942 RID: 31042 RVA: 0x00210424 File Offset: 0x0020E624
		// (set) Token: 0x06007943 RID: 31043 RVA: 0x00039318 File Offset: 0x00037518
		public unsafe float timeSinceLastPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_timeSinceLastPath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_timeSinceLastPath)) = value;
			}
		}

		// Token: 0x040052C3 RID: 21187
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x040052C4 RID: 21188
		private static readonly IntPtr NativeFieldInfoPtr_RepathRate;

		// Token: 0x040052C5 RID: 21189
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastPath;

		// Token: 0x040052C6 RID: 21190
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040052C7 RID: 21191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
