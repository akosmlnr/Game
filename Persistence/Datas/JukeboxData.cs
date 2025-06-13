using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B4 RID: 692
	public class JukeboxData : GridItemData
	{
		// Token: 0x060031F7 RID: 12791 RVA: 0x00112C18 File Offset: 0x00110E18
		// Note: this type is marked as 'beforefieldinit'.
		static JukeboxData()
		{
			Il2CppClassPointerStore<JukeboxData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "JukeboxData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JukeboxData>.NativeClassPtr);
			JukeboxData.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxData>.NativeClassPtr, "State");
			JukeboxData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_JukeboxState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxData>.NativeClassPtr, 100669058);
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x00112C70 File Offset: 0x00110E70
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 136895, RefRangeEnd = 136901, XrefRangeStart = 136895, XrefRangeEnd = 136901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JukeboxData(Il2CppSystem.Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, Jukebox.JukeboxState state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JukeboxData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_JukeboxState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x0001A5B6 File Offset: 0x000187B6
		public JukeboxData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x060031FA RID: 12794 RVA: 0x00112D1C File Offset: 0x00110F1C
		// (set) Token: 0x060031FB RID: 12795 RVA: 0x0001A5BF File Offset: 0x000187BF
		public unsafe Jukebox.JukeboxState State
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxData.NativeFieldInfoPtr_State);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Jukebox.JukeboxState>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxData.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020AB RID: 8363
		private static readonly System.IntPtr NativeFieldInfoPtr_State;

		// Token: 0x040020AC RID: 8364
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_JukeboxState_0;
	}
}
