using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006DD RID: 1757
	public class AssignedWorkerDisplay : MonoBehaviour
	{
		// Token: 0x06009DA7 RID: 40359 RVA: 0x002825F4 File Offset: 0x002807F4
		// Note: this type is marked as 'beforefieldinit'.
		static AssignedWorkerDisplay()
		{
			Il2CppClassPointerStore<AssignedWorkerDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "AssignedWorkerDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignedWorkerDisplay>.NativeClassPtr);
			AssignedWorkerDisplay.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignedWorkerDisplay>.NativeClassPtr, "Icon");
			AssignedWorkerDisplay.NativeMethodInfoPtr_Set_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignedWorkerDisplay>.NativeClassPtr, 100682783);
			AssignedWorkerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignedWorkerDisplay>.NativeClassPtr, 100682784);
		}

		// Token: 0x06009DA8 RID: 40360 RVA: 0x00282660 File Offset: 0x00280860
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280067, RefRangeEnd = 280068, XrefRangeStart = 280056, XrefRangeEnd = 280067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignedWorkerDisplay.NativeMethodInfoPtr_Set_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DA9 RID: 40361 RVA: 0x002826A4 File Offset: 0x002808A4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssignedWorkerDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignedWorkerDisplay>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignedWorkerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DAA RID: 40362 RVA: 0x0004CF7B File Offset: 0x0004B17B
		public AssignedWorkerDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700305B RID: 12379
		// (get) Token: 0x06009DAB RID: 40363 RVA: 0x002826E0 File Offset: 0x002808E0
		// (set) Token: 0x06009DAC RID: 40364 RVA: 0x0004CF84 File Offset: 0x0004B184
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignedWorkerDisplay.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignedWorkerDisplay.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A04 RID: 27140
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04006A05 RID: 27141
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_NPC_0;

		// Token: 0x04006A06 RID: 27142
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
